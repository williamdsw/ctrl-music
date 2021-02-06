using Entities;

namespace Repositories
{
    public interface IMeasuresRepository
    {
        bool Insert(Measures measures);
        bool Update(Measures measures);
        bool Delete(Measures listMeasures);
    }
}
