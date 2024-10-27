using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contract
{
    public interface IRepositoryBase<T> where T : class
    {
        public IQueryable<T?> FindAll(bool trackChanges);
        public T? FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        public void Create(T entity);
        public void Update(T entity);
        public void Delete(T entity);
    }
}
