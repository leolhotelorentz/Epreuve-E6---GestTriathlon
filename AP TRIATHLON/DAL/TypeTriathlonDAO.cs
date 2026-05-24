using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BLL;

namespace DAL
{
    public class TypeTriathlonDAO
    {
        public static List<TypeTriathlon> GetTousLesTypes()
        {
            List<TypeTriathlon> res = new List<TypeTriathlon>();

            using (SqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                string sql = "SELECT codeType, libelleType, distanceNatation, distanceCyclisme, distanceCourse FROM TypeTriathlon";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        res.Add(new TypeTriathlon(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetDecimal(2),
                            dr.GetDecimal(3),
                            dr.GetDecimal(4)
                        ));
                    }
                }
            }

            return res;
        }
        public static TypeTriathlon GetTypeParCode(int codeType)
        {
            using (SqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                string sql = "SELECT codeType, libelleType, distanceNatation, distanceCyclisme, distanceCourse " +
                             "FROM TypeTriathlon WHERE codeType = @code";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@code", codeType);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new TypeTriathlon(
                                dr.GetInt32(0),
                                dr.GetString(1),
                                dr.GetDecimal(2),
                                dr.GetDecimal(3),
                                dr.GetDecimal(4)
                            );
                        }
                    }
                }
            }

            return null;
        }
    }
}