using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contract
{
    public interface IFeaturesService
    {
        public IEnumerable<Features?> GetAll(bool trackChanges);
        public Features? GetOne(int id, bool trackChanges);
        public void CreateOne(Features features);
        public void UpdateOne(int id);
        public void DeleteOne(int id);
    }
}
