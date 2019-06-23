using CsvHelper;
using K_nearest_neighbors.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_nearest_neighbors.Controller
{
    class LoadData
    {
        public LoadData()
        {

        }
        public List<Data> readCsv(string pathCSVFile)
        {
            
            List<Data> listData = new List<Data>();
            using (TextReader reader = File.OpenText(pathCSVFile))
            {
                CsvReader csv = new CsvReader(reader);
                csv.Configuration.Delimiter = ",";
                csv.Configuration.MissingFieldFound = null;
                while (csv.Read())
                {
                    Data Record = csv.GetRecord<Data>();
                    listData.Add(Record);
                }
            }
            return listData;
        }
    }
}
