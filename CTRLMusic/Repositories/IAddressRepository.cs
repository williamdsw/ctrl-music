
using Entities;
using System.Collections.Generic;

namespace Repositories
{
    public interface IAddressRepository
    {
        bool Insert(Address address);
        bool Update(Address address);
        bool Delete(Address address);

        List<Address> SearchAll();
    }
}
