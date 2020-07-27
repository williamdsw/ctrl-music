
using System.Collections.Generic;

namespace CTRLMusic
{
    public interface IEmployeeDao
    {
        bool Insert(Employee employee);
        bool Update(Employee employee);
        bool Delete(List<Employee> employees);

        List<Employee> SearchAll();
        List<Employee> SearchByNameOrEmail(string name, string email);

        Employee GetById(int id);
    }
}
