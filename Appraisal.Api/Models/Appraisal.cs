using System;
using System.Collections.Generic;

#nullable disable

namespace Appraisal.Api.Models
{
    public partial class Appraisal
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int GradeId { get; set; }
        public int RatingId { get; set; }
        public int Year { get; set; }
        public int Increment { get; set; }
        public bool? Active { get; set; }

        public virtual Department Department { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual Rating Rating { get; set; }
    }
}
