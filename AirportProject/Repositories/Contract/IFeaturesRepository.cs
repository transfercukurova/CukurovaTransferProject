using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contract
{
    public interface IFeaturesRepository : IRepositoryBase<Features>
    {
        public IQueryable<Features?> GetAllFeatures(bool trackChanges);
        public Features? GetOneFeatures(int id, bool trackChanges);
        public void CreateFeatures(Features features);
        public void UpdateFeatures(Features features);
        public void DeleteFeatures(Features features);
    }
}
