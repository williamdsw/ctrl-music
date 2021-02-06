
using Entities;
using System.Collections.Generic;

namespace Repositories
{
    public interface IInstrumentRepository
    {
        bool Insert(Instrument instrument);
        bool Update(Instrument instrument);
        bool Delete(List<Instrument> instruments);

        List<Instrument> SearchAll();
        List<Instrument> SearchByNameOrBrandOrDescriptionOrType(string name, string brand, string description, string type);

        Instrument GetById(int id);
    }
}
