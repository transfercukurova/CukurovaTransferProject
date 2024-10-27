using Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class ServiceManager : IServiceManager
    {
        private readonly ICategoryService _categoryService;
        private readonly IFeaturesService _featuresService;

        public ServiceManager(ICategoryService categoryService, IFeaturesService featuresService)
        {
            _categoryService = categoryService;
            _featuresService = featuresService;
        }

        public ICategoryService CategoryService => _categoryService;

        public IFeaturesService FeaturesService => _featuresService;
    }
}
