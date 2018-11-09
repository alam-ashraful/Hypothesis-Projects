using Experiment.Entities;
using Experiment.InfrastructureServices.Base;
using Experiment.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment.InfrastructureServices
{
    public class StudentService : BaseService<Student>, IStudentService { }
}
