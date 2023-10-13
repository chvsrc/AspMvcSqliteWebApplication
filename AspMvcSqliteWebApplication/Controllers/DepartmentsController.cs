using AspMvcSqliteWebApplication.Entities;
using AspMvcSqliteWebApplication.Interfaces;

namespace AspMvcSqliteWebApplication.Controllers
{
    public class DepartmentsController : CommonController<Department>
    {
        public DepartmentsController(IRepository<Department> repository) : base(repository)
        {
        }
    }
}
