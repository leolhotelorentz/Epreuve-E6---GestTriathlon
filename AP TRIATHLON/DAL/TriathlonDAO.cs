using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace DAL
{
    public class TriathlonDAO
    {
        public static List<Triathlon> GetLesTriathlons()
        {
            List<Triathlon> res = new List<Triathlon>();

            using (SqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                string sql = "SELECT idTriathlon, nomTriathlon, lieu, dateTriathlon, codeType FROM Triathlon";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        res.Add(new Triathlon(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetDateTime(3),
                            dr.GetInt32(4)
                        ));
                    }
                }
            }

            return res;
        }

        public static List<Triathlon> GetTriathlonsFiltres(string lieu, int? codeType, DateTime? dateDebut, DateTime? dateFin)
        {
            List<Triathlon> res = new List<Triathlon>();

            using (SqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                string sql = "SELECT idTriathlon, nomTriathlon, lieu, dateTriathlon, codeType FROM Triathlon WHERE 1=1";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;

                    if (!string.IsNullOrEmpty(lieu))
                    {
                        sql += " AND lieu = @lieu";
                        cmd.Parameters.AddWithValue("@lieu", lieu);
                    }

                    if (codeType.HasValue)
                    {
                        sql += " AND codeType = @codeType";
                        cmd.Parameters.AddWithValue("@codeType", codeType.Value);
                    }

                    if (dateDebut.HasValue)
                    {
                        sql += " AND dateTriathlon >= @dateDebut";
                        cmd.Parameters.AddWithValue("@dateDebut", dateDebut.Value.Date);
                    }

                    if (dateFin.HasValue)
                    {
                        sql += " AND dateTriathlon <= @dateFin";
                        cmd.Parameters.AddWithValue("@dateFin", dateFin.Value.Date);
                    }

                    cmd.CommandText = sql;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            res.Add(new Triathlon(
                                dr.GetInt32(0),
                                dr.GetString(1),
                                dr.GetString(2),
                                dr.GetDateTime(3),
                                dr.GetInt32(4)
                            ));
                        }
                    }
                }
            }

            return res;
        }

        public static void SupprimerTriathlon(int idTriathlon)
        {
            using (SqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();
                SqlTransaction tr = cn.BeginTransaction();

                try
                {
                    ExecuteDeleteIfTableExists(cn, tr, 
                        @"DELETE CV FROM CourseVelo CV
                          INNER JOIN Course C ON CV.numEpreuve = C.numEpreuve
                          INNER JOIN Epreuve E ON C.numEpreuve = E.numEpreuve
                          WHERE E.idTriathlon = @id", idTriathlon);

                    ExecuteDeleteIfTableExists(cn, tr,
                        @"DELETE CP FROM CoursePied CP
                          INNER JOIN Course C ON CP.numEpreuve = C.numEpreuve
                          INNER JOIN Epreuve E ON C.numEpreuve = E.numEpreuve
                          WHERE E.idTriathlon = @id", idTriathlon);

                    ExecuteDeleteIfTableExists(cn, tr,
                        @"DELETE N FROM Natation N
                          INNER JOIN Epreuve E ON N.numEpreuve = E.numEpreuve
                          WHERE E.idTriathlon = @id", idTriathlon);

                    ExecuteDeleteIfTableExists(cn, tr,
                        @"DELETE C FROM Course C
                          INNER JOIN Epreuve E ON C.numEpreuve = E.numEpreuve
                          WHERE E.idTriathlon = @id", idTriathlon);

                    ExecuteDeleteIfTableExists(cn, tr,
                        @"DELETE FROM ResultatEpreuve WHERE idTriathlon = @id", idTriathlon);

                    ExecuteDeleteIfTableExists(cn, tr,
                        @"DELETE FROM Epreuve WHERE idTriathlon = @id", idTriathlon);

                    ExecuteDeleteIfTableExists(cn, tr,
                        @"DELETE FROM Inscription WHERE idTriathlon = @id", idTriathlon);

                    ExecuteDeleteIfTableExists(cn, tr,
                        @"DELETE FROM Prelevement WHERE idTriathlon = @id", idTriathlon);

                    using (SqlCommand cmd = new SqlCommand(
                        @"DELETE FROM Triathlon WHERE idTriathlon = @id", cn, tr))
                    {
                        cmd.Parameters.AddWithValue("@id", idTriathlon);
                        cmd.ExecuteNonQuery();
                    }

                    tr.Commit();
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                    throw new Exception("Erreur suppression triathlon : " + ex.Message, ex);
                }
            }
        }

        private static void ExecuteDeleteIfTableExists(SqlConnection cn, SqlTransaction tr, string sql, int idTriathlon)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, cn, tr))
                {
                    cmd.Parameters.AddWithValue("@id", idTriathlon);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
            }
        }

        public static int AjouterTriathlon(Triathlon t)
        {
            using (SqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText =
                    "INSERT INTO Triathlon (idTriathlon, nomTriathlon, lieu, dateTriathlon, codeType) " +
                    "VALUES (@id, @nom, @lieu, @date, @codeType)";

                cmd.Parameters.AddWithValue("@id", t.IdTriathlon);
                cmd.Parameters.AddWithValue("@nom", t.NomTriathlon);
                cmd.Parameters.AddWithValue("@lieu", t.Lieu);
                cmd.Parameters.AddWithValue("@date", t.DateTriathlon);
                cmd.Parameters.AddWithValue("@codeType", t.CodeType);

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

        public static int ModifierTriathlon(Triathlon t)
        {
            using (SqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText =
                    "UPDATE Triathlon SET nomTriathlon = @nom, lieu = @lieu, " +
                    "dateTriathlon = @date, codeType = @codeType WHERE idTriathlon = @id";

                cmd.Parameters.AddWithValue("@nom", t.NomTriathlon);
                cmd.Parameters.AddWithValue("@lieu", t.Lieu);
                cmd.Parameters.AddWithValue("@date", t.DateTriathlon);
                cmd.Parameters.AddWithValue("@codeType", t.CodeType);
                cmd.Parameters.AddWithValue("@id", t.IdTriathlon);

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

    }
}
