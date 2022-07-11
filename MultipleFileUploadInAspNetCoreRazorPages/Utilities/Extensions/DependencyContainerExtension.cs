using MultipleFileUploadInAspNetCoreRazorPages.Services.Implantation;
using MultipleFileUploadInAspNetCoreRazorPages.Services.Interfaces;

namespace MultipleFileUploadInAspNetCoreRazorPages.Utilities.Extensions
{
    public static class DependencyContainerExtension
    {
        public static void RegisterServices(this IServiceCollection service)
        {
            service.AddScoped<IFileUploadLocalService, FileUploadLocalService>();
        }
    }
}
