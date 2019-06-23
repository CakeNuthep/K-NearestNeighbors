using CsvHelper;
using K_nearest_neighbors.Controller;
using K_nearest_neighbors.Model;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K_nearest_neighbors
{
    public partial class Form1 : Form
    {
        public SeriesCollection seriesCollection { get; set; }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button_brows_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse csv Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_filePath.Text = openFileDialog1.FileName;
            }
        }

        private void button_predict_Click(object sender, EventArgs e)
        {
            int K;
            double eat, temperature;
            if (int.TryParse(textBox_k.Text, out K)
                && double.TryParse(textBox_eat.Text, out eat)
                && double.TryParse(textBox_temperature.Text, out temperature))
            {
                string pathCSVFile = textBox_filePath.Text;
                LoadData load = new LoadData();
                List<Data> listData = load.readCsv(pathCSVFile);
                WeightedKNearestNeighborsController wKNN = new WeightedKNearestNeighborsController();
                Data predicData = new Data(eat, temperature, "");
                initialGraph(listData, predicData);
                string result = wKNN.run(listData, predicData, K);
                textBox_sick.Text = result;
            }
        }

        private void initialGraph(List<Data> listData, Data predictData)
        {
            seriesCollection = new SeriesCollection
            {
                 
                new ScatterSeries
                {
                    Title = "Sick",
                    Values = new ChartValues<ObservablePoint>(),
                    StrokeThickness = 2
                },
                new ScatterSeries
                {
                    Title = "Not Sick",
                    Values = new ChartValues<ObservablePoint>(),
                    PointGeometry = DefaultGeometries.Diamond
                },
                new ScatterSeries
                {
                    Title = "Predict",
                    Values = new ChartValues<ObservablePoint>(),
                    PointGeometry = DefaultGeometries.Square,
                    StrokeThickness = 2
                }
            };
            //foreach (var series in SeriesCollection)
            {
                for (int indexListData = 0; indexListData < listData.Count; indexListData++)
                {
                    if (listData[indexListData].Sick.ToUpper() == "Y")
                    {
                        seriesCollection[(int)WeightedKNearestNeighborsController.GroupIndex.Y].Values.Add(
                            new ObservablePoint(listData[indexListData].Eat, listData[indexListData].Temperature));
                    }
                    else
                    {
                        seriesCollection[(int)WeightedKNearestNeighborsController.GroupIndex.N].Values.Add(
                            new ObservablePoint(listData[indexListData].Eat, listData[indexListData].Temperature));
                    }
                }
            }

            {
                
                    seriesCollection[2].Values.Add(
                        new ObservablePoint(predictData.Eat, predictData.Temperature));
                
            }

            cartesianChart1.Series = seriesCollection;
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
        }
    }


}
