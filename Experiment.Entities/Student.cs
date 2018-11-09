using Experiment.Entities.Base;
using System;
using System.Collections.Generic;
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

        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }

        [ForeignKey("CourseId")]
        public int CourseId { get; set; }

        [ForeignKey("SemesterId")]
        public int SemesterId { get; set; }
    }
}
