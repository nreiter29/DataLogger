using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogger.Models {
    public class CSVLoader {

        public List<IWeatherData> weatherDatas { get; set; }
        public void ImportCSV(string path) {
            weatherDatas = new List<IWeatherData>();
            StreamReader sr = new(path);
            string line = sr.ReadLine();
            if(line != "Time;Wind speed;Temperature") {
                throw new Exception("Wrong file format");
            }
            line = sr.ReadLine();
            while(line != null) {
                string[] values = line.Split(';');
                DateTime timeStamp = DateTime.Parse(values[0]);
                weatherDatas.Add(new WindSpeed() { 
                    TimeStamp = timeStamp,
                    Value = double.Parse(values[1], System.Globalization.CultureInfo.InvariantCulture)
                });
                weatherDatas.Add(new Temperature() {
                    TimeStamp = timeStamp,
                    Value = double.Parse(values[1], System.Globalization.CultureInfo.InvariantCulture)
                });
                line = sr.ReadLine();
            }
            sr.Close();
        }

    }
}
