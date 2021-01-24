using Appraisal.Api.DataContract.Models;
using Appraisal.Api.DataContract.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Appraisal.Api.DataAccess.Repositories
{
    public class GradeRepository : RepositoryBase<Grade>, IGradeRepository
    {
        public GradeRepository(PayrollContext payrollContext) : base(payrollContext)
        {
        }

        public IEnumerable<Grade> GetByDepartment(int departmentId)
        {
            return _payrollContext.Grades.Where(g => g.DepartmentId == departmentId);
        }
    }
}
