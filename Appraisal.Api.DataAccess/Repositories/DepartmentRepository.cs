using Appraisal.Api.DataContract.Models;
using Appraisal.Api.DataContract.Repositories;

namespace Appraisal.Api.DataAccess.Repositories
{
    public class DepartmentRepository : RepositoryBase<Department>, IDepartmentRepository
    {
        public DepartmentRepository(PayrollContext payrollContext) : base(payrollContext)
        {

        }
    }
}
