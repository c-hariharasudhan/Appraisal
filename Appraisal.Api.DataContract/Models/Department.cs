using System;
using System.Collections.Generic;

#nullable disable

namespace Appraisal.Api.DataContract.Models
{
    public partial class Department
    {
        public Department()
        {
            Appraisals = new HashSet<Appraisal>();
            Grades = new HashSet<Grade>();
            Ratings = new HashSet<Rating>();
        }

        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Appraisal> Appraisals { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
