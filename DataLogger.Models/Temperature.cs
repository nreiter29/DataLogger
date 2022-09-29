namespace DataLogger.Models {
    public class Temperature : IWeatherData {
        
        public DateTime TimeStamp { get; set; }
        public double? Value { get; set; }
        public override string ToString() {
            return $"Temperatur: {Value}°C {TimeStamp}";
        }

    }
}
