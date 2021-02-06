using Entities;

namespace Repositories
{
    public interface IUserRepository
    {
        bool Insert(User user);
        bool Update(User user);
        bool Delete(User user);

        User GetById(int id);
    }
}
