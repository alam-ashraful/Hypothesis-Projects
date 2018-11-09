using Experiment.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment.ServiceInterfaces.Base
{
    public interface IBaseService<T> where T : BaseModel
    {
        IQueryable<T> All();
        T Find(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
