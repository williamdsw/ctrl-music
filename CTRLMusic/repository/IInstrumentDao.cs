
using CTRLMusic.models;
using System.Collections.Generic;

public interface IInstrumentDao
{
    bool Insert(Instrument instrument);
    bool Update(Instrument instrument);
    bool Delete(List<Instrument> instruments);

    List<Instrument> SearchAll();
    List<Instrument> SearchByNameOrBrandOrDescriptionOrType(string name, string brand, string description, string type);

    Instrument GetById(int id);
}
