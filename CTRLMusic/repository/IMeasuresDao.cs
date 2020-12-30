
using System.Collections.Generic;

public interface IMeasuresDao
{
    bool Insert(Measures measures);
    bool Update(Measures measures);
    bool Delete(Measures listMeasures);
}
