using Entity.Model;
using Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete
{
    public class FeaturesRepository : RepositoryBase<Features>, IFeaturesRepository
    {
        public FeaturesRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateFeatures(Features features) => Create(features);

        public void DeleteFeatures(Features features) => Delete(features);

        public IQueryable<Features?> GetAllFeatures(bool trackChanges) => FindAll(trackChanges);

        public Features? GetOneFeatures(int id, bool trackChanges) => FindByCondition(f => f.FeaturesId.Equals(id), trackChanges);

        public void UpdateFeatures(Features features) => Update(features);
    }
}
