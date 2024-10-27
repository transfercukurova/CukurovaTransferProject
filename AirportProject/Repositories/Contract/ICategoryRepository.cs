using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contract
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
        public IQueryable<Category?> GetAllCategories(bool trackChanges);
        public Category? GetOneCategory(int id, bool trackChanges);
        public void CreateCategory(Category category);
        public void UpdateCategory(Category category);
        public void DeleteCategory(Category category);
    }
}
