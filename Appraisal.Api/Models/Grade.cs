using System;
using System.Collections.Generic;

#nullable disable

namespace Appraisal.Api.Models
{
    public partial class Grade
    {
        public Grade()
        {
            Appraisals = new HashSet<Appraisal>();
        }

        public int Id { get; set; }
        public string GradeName { get; set; }
        public int DepartmentId { get; set; }
        public bool? Active { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Appraisal> Appraisals { get; set; }
    }
}
