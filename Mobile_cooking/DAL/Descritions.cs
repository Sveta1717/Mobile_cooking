using Mobile_cooking.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_cooking.DAL
{
    public class Descritions
    {
        private readonly SqlConnection connection;

        public Descritions(SqlConnection connection)
        {
            this.connection = connection;
        }

        public List<Entities.Description> GetDescription()
        {
            using (SqlCommand cmd = connection.CreateCommand())
            {
                List<Entities.Description> descriptions = new List<Entities.Description>();                
                cmd.CommandText = "SELECT Description_name FROM Descriptions WHERE Recipe_nameId = 40";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    descriptions.Add(new Entities.Description()
                    {
                        Method = reader.GetString(0)
                    });
                }
                reader.Close();
                return descriptions;

            }
        }

    }
}
