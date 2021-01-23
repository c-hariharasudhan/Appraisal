using Appraisal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appraisal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private readonly PayrollContext _payrollContext;

        public GradeController(PayrollContext payrollContext)
        {
            _payrollContext = payrollContext;
        }

        [HttpGet("{departmentId}")]
        public async Task<IActionResult> Get(int departmentId) 
        {
            var grades = await _payrollContext.Grades.Where(g => g.DepartmentId == departmentId).ToListAsync();
            return Ok(grades);
        }
    }
}
