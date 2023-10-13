using AspMvcSqliteWebApplication.DatabaseContexts;
using AspMvcSqliteWebApplication.Entities;
using AspMvcSqliteWebApplication.Interfaces;

namespace AspMvcSqliteWebApplication.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(CompanyContext context) : base(context)
        {
        }
    }
}
