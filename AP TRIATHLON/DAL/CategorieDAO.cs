using System.Collections.Generic;
using System.Data.SqlClient;
using BLL;

namespace DAL
{
    public class CategorieDAO
    {
        public static List<Categorie> GetToutesLesCategories()
        {
            List<Categorie> res = new List<Categorie>();

            using (SqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                string sql = "SELECT codeCategorie, libelle, ageMini, ageMaxi FROM Categorie";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        res.Add(new Categorie(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetInt32(2),
                            dr.GetInt32(3)
                        ));
                    }
                }
            }

            return res;
        }

        public static Categorie GetCategorieParCode(int codeCategorie)
        {
            using (SqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                string sql = "SELECT codeCategorie, libelle, ageMini, ageMaxi FROM Categorie WHERE codeCategorie = @code";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@code", codeCategorie);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new Categorie(
                                dr.GetInt32(0),
                                dr.GetString(1),
                                dr.GetInt32(2),
                                dr.GetInt32(3)
                            );
                        }
                    }
                }
            }

            return null;
        }
    }
}
