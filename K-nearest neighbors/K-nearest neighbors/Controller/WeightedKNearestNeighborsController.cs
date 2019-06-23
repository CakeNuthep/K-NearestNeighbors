using K_nearest_neighbors.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_nearest_neighbors.Controller
{
    class WeightedKNearestNeighborsController
    {
        const int TOTAL_GROUP = 2;
        const string Y = "Y";
        const string N = "N";
        public enum GroupIndex
        {
            N = 0,
            Y = 1
        };
        public string run(List<Data> listInputData, Data predictData,int K)
        {
            double maxTemperature, minTemperature;
            if (findMaxTemperature(listInputData, out maxTemperature)
                && fineMinTemperature(listInputData, out minTemperature))
            {
                List<DataWeightedKNearestNeighborsModel> listData = new List<DataWeightedKNearestNeighborsModel>();
                foreach (Data inputdata in listInputData)
                {
                    DataWeightedKNearestNeighborsModel weightKNNData = new DataWeightedKNearestNeighborsModel();
                    weightKNNData.Eat = inputdata.Eat;
                    weightKNNData.Sick = inputdata.Sick;
                    weightKNNData.Temperature = inputdata.Temperature;
                    weightKNNData.Normalized = NormalizeAttributes(maxTemperature, minTemperature, inputdata.Temperature);

                    double predicNomorized = NormalizeAttributes(maxTemperature, minTemperature, predictData.Temperature);
                    weightKNNData.Distance = EuclideanDistance(weightKNNData.Eat, weightKNNData.Normalized,predictData.Eat, predicNomorized);
                    listData.Add(weightKNNData);
                }
                List<DataWeightedKNearestNeighborsModel> listWeightKNNData = getKElement(K, listData);
                calWeight(listWeightKNNData);
                double[] predicArr;
                if(predicData(listWeightKNNData, out predicArr))
                {
                    if(predicArr[(int)GroupIndex.Y] > predicArr[(int)GroupIndex.N])
                    {
                        return "Y";
                    }
                    else
                    {
                        return "N";
                    }
                }

            }
            return "cannot run";
        }

        public bool findMaxTemperature(List<Data> listInputData, out double max)
        {
            if (listInputData.Count > 0)
            {
                max = listInputData[0].Temperature;
                for(int index=1;index<listInputData.Count;index++)
                {
                    if(max< listInputData[index].Temperature)
                    {
                        max = listInputData[index].Temperature;
                    }
                }
                return true;
            }
            max = -1;
            return false;
        }

        public bool fineMinTemperature(List<Data> listInputData,out double min)
        {
            if (listInputData.Count > 0)
            {
                min = listInputData[0].Temperature;
                for (int index = 1; index < listInputData.Count; index++)
                {
                    if (min > listInputData[index].Temperature)
                    {
                        min = listInputData[index].Temperature;
                    }
                }
                return true;
            }
            min = -1;
            return false;
        }

        private double NormalizeAttributes(double max, double min, double x0)
        {
            double d1 = (x0 - min) / (max - min);
            return d1;
        }

        public double EuclideanDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distance;
        }

        private List<DataWeightedKNearestNeighborsModel> getKElement(int K,List<DataWeightedKNearestNeighborsModel> listWeightData)
        {
            List<DataWeightedKNearestNeighborsModel> listKweihtData = new List<DataWeightedKNearestNeighborsModel>();
            listWeightData.Sort(Compare);
            for(int index=0;index<K;index++)
            {
                listKweihtData.Add(listWeightData[index]);
            }
            return listKweihtData;
        }

        /// <summary>
        /// this method for sum weight from parameter
        /// </summary>
        /// <param name="listWeightData"></param>
        /// <returns>
        ///     List<double> //index 0 mean Y value, index 1 N value
        /// </returns>
        private void calWeight(List<DataWeightedKNearestNeighborsModel> listWeightData)
        {
            if(listWeightData.Count > 0)
            {
                double d1 = listWeightData[0].Distance;
                double dk = listWeightData[listWeightData.Count-1].Distance;
                foreach(DataWeightedKNearestNeighborsModel WeightData in listWeightData)
                {
                    double di = WeightData.Distance;
                    WeightData.Weight = (dk - di) / (dk - d1);
                }
            }
        }

        
        private bool predicData(List<DataWeightedKNearestNeighborsModel> listWeightData,out double[] predictArr)
        {
            
            predictArr = new double[TOTAL_GROUP];
            if(listWeightData.Count>0)
            {
                foreach (DataWeightedKNearestNeighborsModel weightData in listWeightData)
                {
                    if(weightData.Sick.ToUpper() == Y)
                    {
                        predictArr[(int)GroupIndex.Y] = predictArr[(int)GroupIndex.Y] + weightData.Weight;
                    }
                    else
                    {
                        predictArr[(int)GroupIndex.N] = predictArr[(int)GroupIndex.N] + weightData.Weight;
                    }
                }
                return true;
            }
            return false;
        }

        private int Compare(DataWeightedKNearestNeighborsModel data1, DataWeightedKNearestNeighborsModel data2)
        {
            int compare = data1.Distance.CompareTo(data2.Distance);
            // CompareTo() method 
            return compare;

        }
    }
}
