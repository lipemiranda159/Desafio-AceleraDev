using Codenation.AceleraDev.Services;
using Codenation.AceleraDev.Ui.Extensions;
using Condenation.AceleraDev.Domain.Interfaces;
using Condenation.AceleraDev.Domain.Models;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Codenation.AceleraDev.Ui
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddServices();
            var services = serviceCollection.BuildServiceProvider();
            var criptService = services.GetService<ICryptographyService>();
            var aceleraDevApiService = services.GetService<IAceleraDevApiService>();

            var responseApi = aceleraDevApiService.GetDataAsync("f2722417236fa3b5fe3409c84a6c58b1daaef9be").Result;

            var responseCript = criptService.Decript(responseApi);
            Console.WriteLine(
                responseCript.Decifrado
            );


            Console.ReadLine();
        }
    }
}
