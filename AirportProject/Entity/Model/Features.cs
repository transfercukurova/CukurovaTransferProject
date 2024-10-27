using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class Features
    {
        public int FeaturesId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
