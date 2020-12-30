
using System.Collections.Generic;

public interface IProviderDao
{
    bool Insert(Provider provider);
    bool Update(Provider provider);
    bool Delete(List<Provider> provider);

    List<Provider> SearchAll();
    List<Provider> SearchByNameOrIdentification(string name, string identification);

    Provider GetById(int id);
}
