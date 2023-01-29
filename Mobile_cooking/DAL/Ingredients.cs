using Mobile_cooking.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_cooking.DAL
{
    public class Ingredients
    {
        private readonly SqlConnection connection;
        public Ingredients(SqlConnection connection)
        {
            this.connection = connection;
        }
        public List<Entities.Ingredient> GetIngredients()
        {
            using (SqlCommand cmd = connection.CreateCommand())
            {
                List<Entities.Ingredient> ingredients = new List<Entities.Ingredient>();
                cmd.CommandText = "SELECT Ingredients_name FROM Ingredients WHERE Recipe_nameId = 40";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ingredients.Add(new Entities.Ingredient()
                    {
                        Ingredients = reader.GetString(0)
                    });
                }
                reader.Close();
                return ingredients;
            }
        }
    }
}
