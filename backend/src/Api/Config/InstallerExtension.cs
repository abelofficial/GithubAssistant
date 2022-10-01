
using System.Reflection;
using Domain.Interfaces;

namespace Api.Config;
public static class InstallerExtension
{
    public static void InstallServicesFromAssembly(this IServiceCollection services, IConfiguration config)
    {
        var applicationTypes = Assembly.Load("GithubAssistant.Application").ExportedTypes; // AppDomain.CurrentDomain.GetAssemblies()

        InstallServices(applicationTypes, services, config);
        InstallServices(Assembly.GetExecutingAssembly().ExportedTypes, services, config); ;
    }

    private static void InstallServices(IEnumerable<Type> assembly, IServiceCollection services, IConfiguration config)
    {
        var i = assembly.Where(x =>
            typeof(IInstaller).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
        .Select(Activator.CreateInstance)
        .Cast<IInstaller>()
        .ToList();
        foreach (var installer in i)
        {
            installer.InstallServices(services, config);
        }
    }
}