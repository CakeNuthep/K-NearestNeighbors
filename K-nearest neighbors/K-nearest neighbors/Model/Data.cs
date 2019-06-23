using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_nearest_neighbors.Model
{
    class Data
    {
        public double Eat { get; set; }
        public double Temperature { get; set; }
        public string Sick { get; set; }

        public Data()
        {

        }

        public Data(double eat, double temperature, string sick)
        {
            Eat = eat;
            Temperature = temperature;
            Sick = sick;
        }      
    }
}
