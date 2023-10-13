using AspMvcSqliteWebApplication.Entities;
using AspMvcSqliteWebApplication.Interfaces;

namespace AspMvcSqliteWebApplication.Controllers
{
    public class EmployeesController : CommonController<Employee>
    {
        public EmployeesController(IRepository<Employee> repository) : base(repository)
        {
        }
    }
}
