using Frontend;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class UnitTest1
    {
        private HttpClient Client { get; set; }
        private TestServer Server { get; set; }

        public UnitTest1()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Theory]
        [InlineData(2)]
        public async Task TestingJson(int inputNo)
        {
            var expected = JsonConvert.SerializeObject(new { received = inputNo, result = 4 });
            var response = await Client.GetAsync($"/doubling?input=2");
            var result = await response.Content.ReadAsStringAsync();
            Assert.Equal(expected, result);
        }
    }
}
