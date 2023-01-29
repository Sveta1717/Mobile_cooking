using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_cooking.DAL
{
    /// <summary>
    /// Данные из таблицы RecipeName
    /// </summary>
    public class Reciepts
    {
        private readonly SqlConnection connection;
        public Reciepts(SqlConnection connection)
        {
            this.connection = connection;
        }

        public List<Entities.Reciept> Getlist1()
        {
            using(SqlCommand cmd = connection.CreateCommand())
            {
                List<Entities.Reciept> reciepts= new List<Entities.Reciept>();
                cmd.CommandText = "SELECT Recipe_name FROM NameRecipe WHERE Category = 1";
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read()) 
                {
                    reciepts.Add(new Entities.Reciept()
                    {
                        Name= reader.GetString(0)
                    });
                }
                reader.Close();
                return reciepts;
            }
        }

        public List<Entities.Reciept> Getlist2()
        {
            using (SqlCommand cmd = connection.CreateCommand())
            {
                List<Entities.Reciept> reciepts = new List<Entities.Reciept>();
                cmd.CommandText = "SELECT Recipe_name FROM NameRecipe WHERE Category = 2";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reciepts.Add(new Entities.Reciept()
                    {
                        Name = reader.GetString(0)
                    });
                }
                reader.Close();
                return reciepts;
            }
        }
        public List<Entities.Reciept> Getlist3()
        {
            using (SqlCommand cmd = connection.CreateCommand())
            {
                List<Entities.Reciept> reciepts = new List<Entities.Reciept>();
                cmd.CommandText = "SELECT Recipe_name FROM NameRecipe WHERE Category = 3";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reciepts.Add(new Entities.Reciept()
                    {
                        Name = reader.GetString(0)
                    });
                }
                reader.Close();
                return reciepts;
            }
        }
        public List<Entities.Reciept> Getlist4()
        {
            using (SqlCommand cmd = connection.CreateCommand())
            {
                List<Entities.Reciept> reciepts = new List<Entities.Reciept>();
                cmd.CommandText = "SELECT Recipe_name FROM NameRecipe WHERE Category = 4";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reciepts.Add(new Entities.Reciept()
                    {
                        Name = reader.GetString(0)
                    });
                }
                reader.Close();
                return reciepts;
            }
        }
        public List<Entities.Reciept> Getlist5()
        {
            using (SqlCommand cmd = connection.CreateCommand())
            {
                List<Entities.Reciept> reciepts = new List<Entities.Reciept>();
                cmd.CommandText = "SELECT Recipe_name FROM NameRecipe WHERE Category = 5";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reciepts.Add(new Entities.Reciept()
                    {
                        Name = reader.GetString(0)
                    });
                }
                reader.Close();
                return reciepts;
            }
        }
        public List<Entities.Reciept> Getlist6()
        {
            using (SqlCommand cmd = connection.CreateCommand())
            {
                List<Entities.Reciept> reciepts = new List<Entities.Reciept>();
                cmd.CommandText = "SELECT Recipe_name FROM NameRecipe WHERE Category = 6";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reciepts.Add(new Entities.Reciept()
                    {
                        Name = reader.GetString(0)
                    });
                }
                reader.Close();
                return reciepts;
            }
        }
        public List<Entities.Reciept> Getlist7()
        {
            using (SqlCommand cmd = connection.CreateCommand())
            {
                List<Entities.Reciept> reciepts = new List<Entities.Reciept>();
                cmd.CommandText = "SELECT Recipe_name FROM NameRecipe WHERE Category = 7";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reciepts.Add(new Entities.Reciept()
                    {
                        Name = reader.GetString(0)
                    });
                }
                reader.Close();
                return reciepts;
            }
        }
    }
}
