using Experiment.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment.Entities
{
    public class Course : BaseModel
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Courses cannot be add without a department")]
        public int DepartmentId { get; set; }

        public Student Student { get; set; }
        public Department Department { get; set; }
    }
}
