using Appraisal.Api.DataContract;
using Microsoft.AspNetCore.Mvc;

namespace Appraisal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public GradeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{departmentId}")]
        public IActionResult Get(int departmentId) 
        {
            var grades =  _unitOfWork.Grades.GetByDepartment(departmentId);
            return Ok(grades);
        }
    }
}
