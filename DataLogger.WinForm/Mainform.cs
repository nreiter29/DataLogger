using DataLogger.Models;

namespace DataLogger.WinForm {
    public partial class Datenlogger : Form {

        private CSVLoader cSVLoader = new();
        public Datenlogger() {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV-File|*.csv";
            ofd.ShowDialog();
            try {
                cSVLoader.ImportCSV(ofd.FileName);
            } catch(Exception ex) {
                if(ex.Message == "Wrong file format") MessageBox.Show("Fehlerhaftes CSV-File");
                else MessageBox.Show(ex.Message);
            }

            foreach(IWeatherData item in cSVLoader.weatherDatas) {
                if(item.GetType() == typeof(WindSpeed)) ltbData.Items.Add(item);
                else if(item.GetType() == typeof(Temperature)) ltbData2.Items.Add(item);
            }
        }
    }
}