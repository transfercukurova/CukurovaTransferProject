using Entity.Model;
using Repositories.Contract;
using Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepositoryManager _manager;

        public CategoryService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateOne(Category category)
        {
            _manager.Category.CreateCategory(category);
            _manager.Save();
        }

        public void DeleteOne(int id)
        {
            var category = _manager.Category.GetOneCategory(id, true);
            if(category is not null)
            {
                _manager.Category.DeleteCategory(category);
                _manager.Save();
            }
        }

        public IEnumerable<Category?> GetAll(bool trackChanges) => _manager.Category.GetAllCategories(trackChanges);

        public Category? GetOne(int id, bool trackChanges) => _manager.Category.GetOneCategory(id, trackChanges);

        public void UpdateOne(int id)
        {
            var category = _manager.Category.GetOneCategory(id, true);
            if(category is not null)
            {
                _manager.Category.UpdateCategory(category);
                _manager.Save();
            }
        }
    }
}
