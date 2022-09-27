namespace DataLogger.Models {
    public class WindSpeed : IWeatherData {

        public DateTime TimeStamp { get; set; }
        public double? Value { get; set; }
        public override string ToString() {
            return $"Windgeschwindigkeit: {Value}km/h {TimeStamp}";
        }

    }
}