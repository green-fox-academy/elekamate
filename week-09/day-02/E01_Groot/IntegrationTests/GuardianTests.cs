using E01_Groot;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using Newtonsoft.Json;

namespace IntegrationTests
{
    public class GuardianTests
    {
        private HttpClient Client;
        private TestServer Server;

        public GuardianTests()
        {
            //arrange
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/");
            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task IndexShouldNOTReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/index");
            //assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Theory]
        [InlineData("somemessage")]
        public async Task GrootTestOK(string message)
        {
            var expected = JsonConvert.SerializeObject(new { received = "somemessage", translated = "I am Groot!" });
            var response = await Client.GetAsync($"/?message={message}");
            var result = await response.Content.ReadAsStringAsync();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("othermessage")]
        public async Task GrootTestNotOK(string message)
        {
            var expected = JsonConvert.SerializeObject(new { error = "I am Groot!" });
            var response = await Client.GetAsync($"/?message={message}");
            var result = await response.Content.ReadAsStringAsync();
            Assert.Equal(expected, result);
        }
    }
}
