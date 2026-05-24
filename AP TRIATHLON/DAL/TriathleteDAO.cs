using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BLL;

namespace DAL
{
    public class TriathleteDAO
    {
        public static List<Triathlete> GetTousLesTriathletes()
        {
            List<Triathlete> res = new List<Triathlete>();

            using (SqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                string sql = @"SELECT T.numLicence, T.nom, T.prenom, T.sexe, T.adresseRue, T.adresseCP, 
                              T.adresseVille, T.dateNaissance, T.codeCategorie, T.login, C.libelle,
                              (SELECT COUNT(*) FROM Inscription I WHERE I.numLicence = T.numLicence) as nbTriathlons,
                              (SELECT CASE WHEN EXISTS(
                                  SELECT 1 FROM Prelevement P 
                                  INNER JOIN Taux Tx ON P.idPrelevement = Tx.idPrelevement
                                  INNER JOIN ProduitDopant PD ON Tx.idProduitDopant = PD.idProduitDopant
                                  WHERE P.numLicence = T.numLicence AND Tx.mesure > PD.tauxMax
                              ) THEN 1 ELSE 0 END) as positifDopage
                              FROM Triathlete T
                              INNER JOIN Categorie C ON T.codeCategorie = C.codeCategorie";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Triathlete t = new Triathlete(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetString(3)[0],
                            dr.GetString(4),
                            dr.GetString(5),
                            dr.GetString(6),
                            dr.GetDateTime(7),
                            dr.GetInt32(8),
                            dr.GetString(9)
                        );
                        t.LibelleCategorie = dr.GetString(10);
                        t.NbTriathlonsParticipes = dr.GetInt32(11);
                        t.AEtePositifDopage = dr.GetInt32(12) == 1;
                        res.Add(t);
                    }
                }
            }

            return res;
        }

        public static List<Triathlete> GetTriathletesFiltres(int? numLicence, string nom, int? codeCategorie, 
            char? sexe, int? ageMin, int? ageMax, int? idTriathlon)
        {
            List<Triathlete> res = new List<Triathlete>();

            using (SqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                string sql = @"SELECT DISTINCT T.numLicence, T.nom, T.prenom, T.sexe, T.adresseRue, T.adresseCP, 
                              T.adresseVille, T.dateNaissance, T.codeCategorie, T.login, C.libelle,
                              (SELECT COUNT(*) FROM Inscription I WHERE I.numLicence = T.numLicence) as nbTriathlons,
                              (SELECT CASE WHEN EXISTS(
                                  SELECT 1 FROM Prelevement P 
                                  INNER JOIN Taux Tx ON P.idPrelevement = Tx.idPrelevement
                                  INNER JOIN ProduitDopant PD ON Tx.idProduitDopant = PD.idProduitDopant
                                  WHERE P.numLicence = T.numLicence AND Tx.mesure > PD.tauxMax
                              ) THEN 1 ELSE 0 END) as positifDopage
                              FROM Triathlete T
                              INNER JOIN Categorie C ON T.codeCategorie = C.codeCategorie
                              WHERE 1=1";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;

                    if (numLicence.HasValue)
                    {
                        sql += " AND T.numLicence = @numLicence";
                        cmd.Parameters.AddWithValue("@numLicence", numLicence.Value);
                    }

                    if (!string.IsNullOrEmpty(nom))
                    {
                        sql += " AND T.nom LIKE @nom + '%'";
                        cmd.Parameters.AddWithValue("@nom", nom);
                    }

                    if (codeCategorie.HasValue)
                    {
                        sql += " AND T.codeCategorie = @codeCategorie";
                        cmd.Parameters.AddWithValue("@codeCategorie", codeCategorie.Value);
                    }

                    if (sexe.HasValue)
                    {
                        sql += " AND T.sexe = @sexe";
                        cmd.Parameters.AddWithValue("@sexe", sexe.Value.ToString());
                    }

                    if (ageMin.HasValue)
                    {
                        sql += " AND DATEDIFF(YEAR, T.dateNaissance, GETDATE()) >= @ageMin";
                        cmd.Parameters.AddWithValue("@ageMin", ageMin.Value);
                    }

                    if (ageMax.HasValue)
                    {
                        sql += " AND DATEDIFF(YEAR, T.dateNaissance, GETDATE()) <= @ageMax";
                        cmd.Parameters.AddWithValue("@ageMax", ageMax.Value);
                    }

                    if (idTriathlon.HasValue)
                    {
                        sql += " AND EXISTS(SELECT 1 FROM Inscription I WHERE I.numLicence = T.numLicence AND I.idTriathlon = @idTriathlon)";
                        cmd.Parameters.AddWithValue("@idTriathlon", idTriathlon.Value);
                    }

                    cmd.CommandText = sql;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Triathlete t = new Triathlete(
                                dr.GetInt32(0),
                                dr.GetString(1),
                                dr.GetString(2),
                                dr.GetString(3)[0],
                                dr.GetString(4),
                                dr.GetString(5),
                                dr.GetString(6),
                                dr.GetDateTime(7),
                                dr.GetInt32(8),
                                dr.GetString(9)
                            );
                            t.LibelleCategorie = dr.GetString(10);
                            t.NbTriathlonsParticipes = dr.GetInt32(11);
                            t.AEtePositifDopage = dr.GetInt32(12) == 1;
                            res.Add(t);
                        }
                    }
                }
            }

            return res;
        }

        public static Triathlete GetTriathleteParNumLicence(int numLicence)
        {
            using (SqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                string sql = @"SELECT T.numLicence, T.nom, T.prenom, T.sexe, T.adresseRue, T.adresseCP, 
                              T.adresseVille, T.dateNaissance, T.codeCategorie, T.login, C.libelle,
                              (SELECT COUNT(*) FROM Inscription I WHERE I.numLicence = T.numLicence) as nbTriathlons,
                              (SELECT CASE WHEN EXISTS(
                                  SELECT 1 FROM Prelevement P 
                                  INNER JOIN Taux Tx ON P.idPrelevement = Tx.idPrelevement
                                  INNER JOIN ProduitDopant PD ON Tx.idProduitDopant = PD.idProduitDopant
                                  WHERE P.numLicence = T.numLicence AND Tx.mesure > PD.tauxMax
                              ) THEN 1 ELSE 0 END) as positifDopage
                              FROM Triathlete T
                              INNER JOIN Categorie C ON T.codeCategorie = C.codeCategorie
                              WHERE T.numLicence = @numLicence";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@numLicence", numLicence);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            Triathlete t = new Triathlete(
                                dr.GetInt32(0),
                                dr.GetString(1),
                                dr.GetString(2),
                                dr.GetString(3)[0],
                                dr.GetString(4),
                                dr.GetString(5),
                                dr.GetString(6),
                                dr.GetDateTime(7),
                                dr.GetInt32(8),
                                dr.GetString(9)
                            );
                            t.LibelleCategorie = dr.GetString(10);
                            t.NbTriathlonsParticipes = dr.GetInt32(11);
                            t.AEtePositifDopage = dr.GetInt32(12) == 1;
                            return t;
                        }
                    }
                }
            }

            return null;
        }

        public static int ModifierTriathlete(Triathlete t)
        {
            using (SqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"UPDATE Triathlete SET nom = @nom, prenom = @prenom, sexe = @sexe, 
                                   adresseRue = @adresseRue, adresseCP = @adresseCP, adresseVille = @adresseVille, 
                                   dateNaissance = @dateNaissance, codeCategorie = @codeCategorie 
                                   WHERE numLicence = @numLicence";

                cmd.Parameters.AddWithValue("@nom", t.Nom);
                cmd.Parameters.AddWithValue("@prenom", t.Prenom);
                cmd.Parameters.AddWithValue("@sexe", t.Sexe.ToString());
                cmd.Parameters.AddWithValue("@adresseRue", t.AdresseRue);
                cmd.Parameters.AddWithValue("@adresseCP", t.AdresseCP);
                cmd.Parameters.AddWithValue("@adresseVille", t.AdresseVille);
                cmd.Parameters.AddWithValue("@dateNaissance", t.DateNaissance);
                cmd.Parameters.AddWithValue("@codeCategorie", t.CodeCategorie);
                cmd.Parameters.AddWithValue("@numLicence", t.NumLicence);

                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch
                {
                    return -1;
                }
            }
        }

        public static int ReinitialiserMotDePasse(int numLicence, string nouveauMotDePasseHash)
        {
            using (SqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                string sqlGetLogin = "SELECT login FROM Triathlete WHERE numLicence = @numLicence";
                string login = null;

                using (SqlCommand cmd = new SqlCommand(sqlGetLogin, cn))
                {
                    cmd.Parameters.AddWithValue("@numLicence", numLicence);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        login = result.ToString();
                }

                if (login != null)
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandText = "UPDATE Utilisateur SET motDePasseHash = @mdp WHERE login = @login";
                        cmd.Parameters.AddWithValue("@mdp", nouveauMotDePasseHash);
                        cmd.Parameters.AddWithValue("@login", login);

                        try
                        {
                            return cmd.ExecuteNonQuery();
                        }
                        catch
                        {
                            return -1;
                        }
                    }
                }

                return -1;
            }
        }

        public static void SupprimerTriathlete(int numLicence)
        {
            using (SqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();
                SqlTransaction tr = cn.BeginTransaction();

                try
                {
                    string login = null;
                    using (SqlCommand cmd = new SqlCommand("SELECT login FROM Triathlete WHERE numLicence = @numLicence", cn, tr))
                    {
                        cmd.Parameters.AddWithValue("@numLicence", numLicence);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                            login = result.ToString();
                    }

                    ExecuteDeleteIfTableExists(cn, tr,
                        @"DELETE FROM Taux WHERE idPrelevement IN 
                          (SELECT idPrelevement FROM Prelevement WHERE numLicence = @numLicence)", numLicence);

                    ExecuteDeleteIfTableExists(cn, tr,
                        @"DELETE FROM Prelevement WHERE numLicence = @numLicence", numLicence);

                    ExecuteDeleteIfTableExists(cn, tr,
                        @"DELETE FROM ResultatEpreuve WHERE idTriathlon IN 
                          (SELECT idTriathlon FROM Inscription WHERE numLicence = @numLicence) 
                          AND numDossard IN (SELECT numDossard FROM Inscription WHERE numLicence = @numLicence)", numLicence);

                    ExecuteDeleteIfTableExists(cn, tr,
                        @"DELETE FROM Inscription WHERE numLicence = @numLicence", numLicence);

                    using (SqlCommand cmd = new SqlCommand(
                        @"DELETE FROM Triathlete WHERE numLicence = @numLicence", cn, tr))
                    {
                        cmd.Parameters.AddWithValue("@numLicence", numLicence);
                        cmd.ExecuteNonQuery();
                    }

                    if (!string.IsNullOrEmpty(login))
                    {
                        using (SqlCommand cmd = new SqlCommand(
                            @"DELETE FROM Utilisateur WHERE login = @login", cn, tr))
                        {
                            cmd.Parameters.AddWithValue("@login", login);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    tr.Commit();
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                    throw new Exception("Erreur suppression triathlète : " + ex.Message, ex);
                }
            }
        }

        private static void ExecuteDeleteIfTableExists(SqlConnection cn, SqlTransaction tr, string sql, int param)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, cn, tr))
                {
                    cmd.Parameters.AddWithValue("@numLicence", param);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
            }
        }
    }
}
