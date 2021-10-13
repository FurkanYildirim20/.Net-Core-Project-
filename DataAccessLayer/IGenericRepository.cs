using CoreLayer.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IGenericRepository<TEntity> where TEntity: class, IEntity, new()
    {
        void Insert(TEntity TEntity);
        void Delete(int id);
        void Update(TEntity TEntity);
        public List<TEntity> GetList();
        //public IQueryable<TEntity> GetQuery();
        public TEntity GetById(int id);
    }
}
