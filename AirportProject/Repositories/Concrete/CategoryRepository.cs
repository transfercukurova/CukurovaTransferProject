using Entity.Model;
using Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateCategory(Category category) => Create(category);

        public void DeleteCategory(Category category) => Delete(category);

        public Category? GetOneCategory(int id, bool trackChanges) => FindByCondition(c => c.CategoryId.Equals(id), trackChanges);

        public IQueryable<Category?> GetAllCategories(bool trackChanges) => FindAll(trackChanges);

        public void UpdateCategory(Category category) => Update(category);
    }
}
