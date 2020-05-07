using Codenation.AceleraDev.Services.Interfaces;
using Condenation.AceleraDev.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Codenation.AceleraDev.Ui.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddServices(this IServiceCollection service)
        {
            service.AddSingleton<ICryptographyService, CriptographyService>();
            service.AddSingleton<ISha1CriptService, Sha1CriptService>();
        }
    }
}
