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
    public class FeaturesService : IFeaturesService
    {
        private readonly IRepositoryManager _manager;

        public FeaturesService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateOne(Features features)
        {
            _manager.Features.CreateFeatures(features);
            _manager.Save();
        }

        public void DeleteOne(int id)
        {
            var features = _manager.Features.GetOneFeatures(id, true);
            if(features is not null)
            {
                _manager.Features.DeleteFeatures(features);
                _manager.Save();
            }
        }

        public IEnumerable<Features?> GetAll(bool trackChanges) => _manager.Features.GetAllFeatures(trackChanges);

        public Features? GetOne(int id, bool trackChanges) => _manager.Features.GetOneFeatures(id, trackChanges);

        public void UpdateOne(int id)
        {
            var features = _manager.Features.GetOneFeatures(id, true);
            if (features is not null)
            {
                _manager.Features.UpdateFeatures(features);
                _manager.Save();
            }
        }
    }
}
