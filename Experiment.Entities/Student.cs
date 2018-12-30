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
    public class Student : BaseModel
    {
        public DateTime BirthDate { get; set; }
        public float CGPA { get; set; }

        [Required(ErrorMessage = "Without department student cann't be create.")]
        public int DepartmentId { get; set; }

        public int CourseId { get; set; }
        public int SemesterId { get; set; }

        public ICollection<Department> department { get; set; }
    }
}
