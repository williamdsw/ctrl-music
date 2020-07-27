
namespace CTRLMusic
{
    public interface IUserDao
    {
        bool Insert(User user);
        bool Update(User user);
        bool Delete(User user);

        User GetById(int id);
    }
}
