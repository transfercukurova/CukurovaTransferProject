using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contract
{
    public interface ICategoryService
    {
        public IEnumerable<Category?> GetAll(bool trackChanges);
        public Category? GetOne(int id, bool trackChanges);
        public void CreateOne(Category category);
        public void UpdateOne(int id);
        public void DeleteOne(int id);
    }
}
