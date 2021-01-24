using Appraisal.Api.DataContract.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appraisal.Api.DataContract.Repositories
{
    public interface IGradeRepository : IRepository<Grade>
    {
        IEnumerable<Grade> GetByDepartment(int departmentId);
    }
}
