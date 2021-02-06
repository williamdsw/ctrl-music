
using Entities;
using Repositories;
using System.Collections.Generic;

namespace Services
{
    public class EmployeeService : IEmployeeRepository
    {
        public bool Delete(List<Employee> employees)
        {
            throw new System.NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Insert(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public List<Employee> SearchAll()
        {
            throw new System.NotImplementedException();
        }

        public List<Employee> SearchByNameOrEmail(string name, string email)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Employee employee)
        {
            throw new System.NotImplementedException();
        }
    }
}
