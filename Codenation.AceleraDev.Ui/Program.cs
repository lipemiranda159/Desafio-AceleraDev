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

            var response = criptService.Cript(
                    new Response()
                    {
                        Decifrado = "a ligeira raposa marrom saltou sobre o cachorro cansado",
                        NumeroCasas = 3
                    });

            Console.WriteLine(
                response.Cifrado
            );


            Console.ReadLine();
        }
    }
}
