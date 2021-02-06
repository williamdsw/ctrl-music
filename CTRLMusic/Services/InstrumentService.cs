
using Entities;
using Repositories;
using System.Collections.Generic;

namespace Services
{
    public class InstrumentService : IInstrumentRepository
    {
        public bool Delete(List<Instrument> instruments)
        {
            throw new System.NotImplementedException();
        }

        public Instrument GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Insert(Instrument instrument)
        {
            throw new System.NotImplementedException();
        }

        public List<Instrument> SearchAll()
        {
            throw new System.NotImplementedException();
        }

        public List<Instrument> SearchByNameOrBrandOrDescriptionOrType(string name, string brand, string description, string type)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Instrument instrument)
        {
            throw new System.NotImplementedException();
        }
    }
}
