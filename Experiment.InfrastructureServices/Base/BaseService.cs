using Experiment.Data;
using Experiment.Entities.Base;
using Experiment.ServiceInterfaces.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment.InfrastructureServices.Base
{
    public class BaseService<T> : IBaseService<T> where T : BaseModel
    {
        private readonly ExperimentDbContext _dbContext;
        private DbSet<T> _innerDbSet;
        public BaseService()
        {
            _dbContext = new ExperimentDbContext();
            _innerDbSet = _dbContext.Set<T>();
        }

        public IQueryable<T> All()
        {
            return _innerDbSet.Where(x => !x.IsDelete);
        }

        public void Delete(int id)
        {
            var entity = Find(id);
            entity.IsDelete = true;
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.Configuration.ValidateOnSaveEnabled = false;
            Save();
            _dbContext.Configuration.ValidateOnSaveEnabled = true;
        }

        public T Find(int id)
        {
            return _innerDbSet.FirstOrDefault(x => x.Id == id && !x.IsDelete);
        }

        public void Insert(T entity)
        {
            entity.CreatedDate = entity.UpdatedDate = DateTime.UtcNow;
            _dbContext.Entry(entity).State = EntityState.Added;
            _innerDbSet.Add(entity);
            Save();
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.Configuration.ValidateOnSaveEnabled = false;
            Save();
            _dbContext.Configuration.ValidateOnSaveEnabled = true;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _innerDbSet = null;
            _dbContext.Dispose();
        }
    }
}
