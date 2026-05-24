using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BLL;

namespace DAL
{
    public class InscriptionDAO
    {
        public static List<Inscription> GetInscriptionsParNumLicence(int numLicence)
        {
            List<Inscription> res = new List<Inscription>();

            using (SqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                string sql = @"SELECT I.idTriathlon, I.numDossard, I.dateInscription, I.forfait, I.numLicence,
                              T.nomTriathlon, T.dateTriathlon, T.lieu
                              FROM Inscription I
                              INNER JOIN Triathlon T ON I.idTriathlon = T.idTriathlon
                              WHERE I.numLicence = @numLicence
                              ORDER BY T.dateTriathlon DESC";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@numLicence", numLicence);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Inscription i = new Inscription(
                                dr.GetInt32(0),
                                dr.GetInt32(1),
                                dr.GetDateTime(2),
                                dr.GetBoolean(3),
                                dr.GetInt32(4)
                            );
                            i.NomTriathlon = dr.GetString(5);
                            i.DateTriathlon = dr.GetDateTime(6);
                            i.LieuTriathlon = dr.GetString(7);
                            res.Add(i);
                        }
                    }
                }
            }

            return res;
        }

        public static Inscription GetInscription(int idTriathlon, int numDossard)
        {
            using (SqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                string sql = @"SELECT I.idTriathlon, I.numDossard, I.dateInscription, I.forfait, I.numLicence,
                              T.nomTriathlon, T.dateTriathlon, T.lieu
                              FROM Inscription I
                              INNER JOIN Triathlon T ON I.idTriathlon = T.idTriathlon
                              WHERE I.idTriathlon = @idTriathlon AND I.numDossard = @numDossard";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@idTriathlon", idTriathlon);
                    cmd.Parameters.AddWithValue("@numDossard", numDossard);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            Inscription i = new Inscription(
                                dr.GetInt32(0),
                                dr.GetInt32(1),
                                dr.GetDateTime(2),
                                dr.GetBoolean(3),
                                dr.GetInt32(4)
                            );
                            i.NomTriathlon = dr.GetString(5);
                            i.DateTriathlon = dr.GetDateTime(6);
                            i.LieuTriathlon = dr.GetString(7);
                            return i;
                        }
                    }
                }
            }

            return null;
        }

        public static int AjouterInscription(Inscription i)
        {
            using (SqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO Inscription (idTriathlon, numDossard, dateInscription, forfait, numLicence) 
                                   VALUES (@idTriathlon, @numDossard, @dateInscription, @forfait, @numLicence)";

                cmd.Parameters.AddWithValue("@idTriathlon", i.IdTriathlon);
                cmd.Parameters.AddWithValue("@numDossard", i.NumDossard);
                cmd.Parameters.AddWithValue("@dateInscription", i.DateInscription);
                cmd.Parameters.AddWithValue("@forfait", i.Forfait);
                cmd.Parameters.AddWithValue("@numLicence", i.NumLicence);

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

        public static int ModifierInscription(Inscription i)
        {
            using (SqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"UPDATE Inscription SET dateInscription = @dateInscription, forfait = @forfait 
                                   WHERE idTriathlon = @idTriathlon AND numDossard = @numDossard";

                cmd.Parameters.AddWithValue("@dateInscription", i.DateInscription);
                cmd.Parameters.AddWithValue("@forfait", i.Forfait);
                cmd.Parameters.AddWithValue("@idTriathlon", i.IdTriathlon);
                cmd.Parameters.AddWithValue("@numDossard", i.NumDossard);

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

        public static int SupprimerInscription(int idTriathlon, int numDossard)
        {
            using (SqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"DELETE FROM Inscription WHERE idTriathlon = @idTriathlon AND numDossard = @numDossard";

                cmd.Parameters.AddWithValue("@idTriathlon", idTriathlon);
                cmd.Parameters.AddWithValue("@numDossard", numDossard);

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

        public static int GetProchainNumDossard(int idTriathlon)
        {
            using (SqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                string sql = "SELECT ISNULL(MAX(numDossard), 0) + 1 FROM Inscription WHERE idTriathlon = @idTriathlon";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@idTriathlon", idTriathlon);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
    }
}
