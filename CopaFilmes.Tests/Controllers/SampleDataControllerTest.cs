
using System.Collections.Generic;
using System.Threading.Tasks;
using CopaFilmes.Controllers;
using Xunit;
using static CopaFilmes.Controllers.SampleDataController;

namespace CopaFilmes.Tests.Controllers
{
    public class SampleDataControllerTest
    {
        public SampleDataControllerTest()
        {
            
        }

        [Fact]
        public async Task TestNameAsync()
        {
            var sampleDataController = new SampleDataController();
            var result = sampleDataController.WeatherForecasts();

            Assert.False(result == null);
        }
    }
}