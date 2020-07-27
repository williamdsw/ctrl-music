
using System.Collections.Generic;

namespace CTRLMusic
{
    public interface IMeasuresDao
    {
        bool Insert(Measures measures);
        bool Update(Measures measures);
        bool Delete(Measures listMeasures);
    }
}
