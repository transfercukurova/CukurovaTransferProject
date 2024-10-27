using Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IFeaturesRepository _featuresRepository;

        public RepositoryManager(RepositoryContext context, ICategoryRepository categoryRepository, IFeaturesRepository featuresRepository)
        {
            _context = context;
            _categoryRepository = categoryRepository;
            _featuresRepository = featuresRepository;
        }

        public ICategoryRepository Category => _categoryRepository;

        public IFeaturesRepository Features => _featuresRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
