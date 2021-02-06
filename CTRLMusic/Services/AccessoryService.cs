
using Entities;
using Repositories;
using System.Collections.Generic;

namespace Services
{
    public class AccessoryService : IAccessoryRepository
    {
        public bool Delete(List<Accessory> accessories)
        {
            throw new System.NotImplementedException();
        } 

        public Accessory GetById(int id)
        {
            throw new System.NotImplementedException();
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
