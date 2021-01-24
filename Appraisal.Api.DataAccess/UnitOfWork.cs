using Appraisal.Api.DataContract;
using Appraisal.Api.DataContract.Repositories;

namespace Appraisal.Api.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PayrollContext _payrollContext;
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IGradeRepository _gradeRepository;
        private readonly IRatingRepository _ratingRepository;

        public IDepartmentRepository Departments => _departmentRepository;

        public IGradeRepository Grades => _gradeRepository;

        public IRatingRepository Ratings => _ratingRepository;

        public UnitOfWork(PayrollContext payrollContext, IDepartmentRepository departmentRepository, IGradeRepository gradeRepository, IRatingRepository ratingRepository)
        {
            _payrollContext = payrollContext;
            _departmentRepository = departmentRepository;
            _gradeRepository = gradeRepository;
            _ratingRepository = ratingRepository;
        }
        public int Complete()
        {
            return _payrollContext.SaveChanges();
        }
    }
}
