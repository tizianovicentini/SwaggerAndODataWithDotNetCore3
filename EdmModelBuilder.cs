using Microsoft.AspNet.OData.Builder;
using Microsoft.OData.Edm;

namespace NSwagAppProto01
{
    public static class EdmModelBuilder
    {
        private static IEdmModel _edmModel;

        public static IEdmModel GetEdmModel()
        {
            if (_edmModel == null)
            {
                var builder = new ODataConventionModelBuilder();
                builder.EntitySet<WeatherForecast>("WeatherForecasts");

                _edmModel = builder.GetEdmModel();
            }

            return _edmModel;
        }
    }

}
