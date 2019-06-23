using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_nearest_neighbors.Model
{
    class DataWeightedKNearestNeighborsModel : Data
    {
        public double Normalized { get; set; }
        public double Distance { get; set; }
        public double Weight { get;set; }
    }
}
