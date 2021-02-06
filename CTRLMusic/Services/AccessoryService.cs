
using Entities;
using Configuration;
using Mono.Data.Sqlite;
using Repositories;
using System;
using System.Collections.Generic;
using System.Data;

namespace Services
{
    public class AccessoryService : IAccessoryRepository
    {
        private DatabaseService database = new DatabaseService();

        public bool Delete(Accessory accessory)
        {
            bool hasDeleted = false;

            using (SqliteConnection connection = database.OpenConnection())
            {
                using (SqliteCommand command = new SqliteCommand(connection))
                {
                    command.CommandText = Queries.Acessories.DeleteOne;
                    command.Parameters.AddWithValue("@accessory_id", accessory.Id);
                    command.Parameters.AddWithValue("@product_id", accessory.ProductId);

                    hasDeleted = (command.ExecuteNonQuery() == 1);
                }
            }

            return hasDeleted;
        } 

        public Accessory GetById(int id)
        {
            Accessory accessory = new Accessory();

            using (SqliteConnection connection = database.OpenConnection())
            {
                using (SqliteCommand command = new SqliteCommand(connection))
                {
                    command.CommandText = Queries.Acessories.GetById;
                    command.Parameters.AddWithValue("@accessory_id", id);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows && reader.RecordsAffected == 1)
                        {
                            //var temp = reader.
                        }
                    }
                }
            }

            return accessory;
        }

        public bool Insert(Accessory accessory)
        {
            throw new System.NotImplementedException();
        }

        public List<Accessory> SearchAll()
        {
            throw new System.NotImplementedException();
        }

        public List<Accessory> SearchByNameOrBrandOrDescription(string name, string brand, string description)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Accessory accessory)
        {
            throw new System.NotImplementedException();
        }
    }
}
