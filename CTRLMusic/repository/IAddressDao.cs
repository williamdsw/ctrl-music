
using System.Collections.Generic;

public interface IAddressDao
{
    bool Insert(Address address);
    bool Update(Address address);
    bool Delete(Address address);

    List<Address> SearchAll();
}
