
using Entities;
using System.Collections.Generic;

namespace Repositories
{
    public interface IAccessoryRepository
    { 
        bool Insert(Accessory accessory);
        bool Update(Accessory accessory);
        bool Delete(Accessory accessory);

        List<Accessory> SearchAll();
        List<Accessory> SearchByNameOrBrandOrDescription(string name, string brand, string description);

        Accessory GetById(int id);
    }
}


