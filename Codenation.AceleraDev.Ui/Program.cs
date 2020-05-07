using Codenation.AceleraDev.Services;
using Codenation.AceleraDev.Services.Extension;
using Codenation.AceleraDev.Ui.Extensions;
using Condenation.AceleraDev.Domain.Interfaces;
using Condenation.AceleraDev.Domain.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Codenation.AceleraDev.Ui
{
    class Program
    {
        public static async Task Upload(byte[] file)
        {
            using (var client = new HttpClient())
            {
                using (var content =
                    new MultipartFormDataContent("Upload----" + DateTime.Now.ToString(CultureInfo.InvariantCulture)))
                {
                    content.Add(new StreamContent(new MemoryStream(file)), "answer", "answer.json");

                    using (
                       var message =
                           await client.PostAsync("https://api.codenation.dev/v1/challenge/dev-ps/submit-solution?token=f2722417236fa3b5fe3409c84a6c58b1daaef9be", content))
                    {
                        var input = await message.Content.ReadAsStringAsync();

                    }
                }
            }
        }
        static void Main(string[] args)
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddServices();
            var services = serviceCollection.BuildServiceProvider();
            var criptService = services.GetService<ICryptographyService>();
            var aceleraDevApiService = services.GetService<IAceleraDevApiService>();
            var token = "f2722417236fa3b5fe3409c84a6c58b1daaef9be";
            var responseApi = aceleraDevApiService.GetDataAsync(token).Result;

            var responseCript = criptService.Decript(responseApi);
            Console.WriteLine(
                responseCript.Decifrado
            );
            Upload(responseCript.ToByteArray()).Wait();


            Console.ReadLine();
        }
    }
}
