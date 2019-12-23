using System;
using Microsoft.OData.Edm.Vocabularies;

namespace NSwagAppProto01
{
    /// <summary>
    /// Weather forecast structure
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Key for OData purpose
        /// </summary>
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Date of forecast
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Temperature in Celsius
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Temperature in Farenight
        /// </summary>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        /// <summary>
        /// Summary string!
        /// </summary>
        public string Summary { get; set; }
    }
}
