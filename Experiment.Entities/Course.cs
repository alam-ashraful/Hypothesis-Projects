using Experiment.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment.Entities
{
    public class Course : BaseModel
    {
        [ForeignKey("StudentId")]
        public int StudentId { get; set; }

        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
    }
}
