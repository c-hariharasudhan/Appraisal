using Appraisal.Api.DataContract.Models;
using Appraisal.Api.DataContract.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Appraisal.Api.DataAccess.Repositories
{
    public class RatingRepository : RepositoryBase<Rating>, IRatingRepository
    {
        public RatingRepository(PayrollContext payrollContext) : base(payrollContext)
        {
        }

        public IEnumerable<Rating> GetByDepartment(int departmentId)
        {
            return _payrollContext.Ratings.Where(r => r.DepartmentId == departmentId);
        }
    }
}
