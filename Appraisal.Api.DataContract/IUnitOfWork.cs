using Appraisal.Api.DataContract.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appraisal.Api.DataContract
{
    public interface IUnitOfWork
    {
        IDepartmentRepository Departments { get; }
        IGradeRepository Grades { get; }
        IRatingRepository Ratings { get; }
        int Complete();
    }
}
