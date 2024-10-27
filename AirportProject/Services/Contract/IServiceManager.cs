using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contract
{
    public interface IServiceManager
    {
        public ICategoryService CategoryService { get; }
        public IFeaturesService FeaturesService { get; }
    }
}
