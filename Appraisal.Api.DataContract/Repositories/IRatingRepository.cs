using Appraisal.Api.DataContract.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appraisal.Api.DataContract.Repositories
{
    public interface IRatingRepository : IRepository<Rating>
    {
        IEnumerable<Rating> GetByDepartment(int departmentId);
    }
}
