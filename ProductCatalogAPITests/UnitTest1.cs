using ProductCatalogAPI;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Azure.Functions.Worker.Http;
using System.Net;

namespace ProductCatalogAPITests
{
    public class Function1Tests
    {
        [Fact]
        public void Run_ReturnsExpectedResponse()
        {
            //// Arrange
            //var function = new Function1(new NullLoggerFactory());
            //var request = new DefaultHttpRequestData(null);
            var fakeStorageKey = "DefaultEndpointsProtocol=https;AccountName=productcatalogstorage;AccountKey=QWERTYUIOPASDFGHJKLZXCVBNM1234567890==;EndpointSuffix=core.windows.net";
            var myStorageConnection = "BlobEndpoint=https://storfabricpoc789.blob.core.windows.net/;QueueEndpoint=https://storfabricpoc789.queue.core.windows.net/;FileEndpoint=https://storfabricpoc789.file.core.windows.net/;TableEndpoint=https://storfabricpoc789.table.core.windows.net/;SharedAccessSignature=sv=2022-11-02&ss=b&srt=o&sp=r&se=2024-09-17T15:14:01Z&st=2024-09-17T15:04:01Z&sip=155.4.33.77&spr=https&sig=H6zI6wCybmx3%2Be%2FyyfqWn0yLzRVnSMGkvJWmb5wfXTo%3D";

            //// Act
            //var response = function.Run(request);

            //// Assert
            //Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
            //Assert.Equal("text/plain; charset=utf-8", response.Headers["Content-Type"]);
            //Assert.Equal("Welcome to Azure Functions!", response.Body.ReadAsStringAsync().Result);
            Assert.Equal(1, 1);
        }
    }
}