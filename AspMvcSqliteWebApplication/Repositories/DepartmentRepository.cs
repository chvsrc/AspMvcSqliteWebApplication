using AspMvcSqliteWebApplication.DatabaseContexts;
using AspMvcSqliteWebApplication.Entities;
using AspMvcSqliteWebApplication.Interfaces;

namespace AspMvcSqliteWebApplication.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(CompanyContext context) : base(context)
        {
        }
    }
}
