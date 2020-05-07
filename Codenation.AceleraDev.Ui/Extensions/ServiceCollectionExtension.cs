using Codenation.AceleraDev.Services;
using Codenation.AceleraDev.Services.Interfaces;
using Condenation.AceleraDev.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using RestEase;

namespace Codenation.AceleraDev.Ui.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddServices(this IServiceCollection service)
        {
            service.AddSingleton<ICryptographyService, CriptographyService>();
            service.AddSingleton<ISha1CriptService, Sha1CriptService>();
            service.AddSingleton(new RestClient("https://api.codenation.dev/v1/challenge/dev-ps").For<IAceleraDevApiService>());
        }
    }
}
