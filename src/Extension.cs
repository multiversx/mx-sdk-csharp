using Erdcsharp.Manager;
using Erdcsharp.Provider;

namespace Erdcsharp
{
    public static class Extension
    {

        //public static IServiceCollection AddElrondProvider(this IServiceCollection services, Network network)
        //{
        //    var configuration = new ElrondNetworkConfiguration(network);
        //    services.AddSingleton(configuration);
        //    services.AddHttpClient<IElrondProvider, ElrondProvider>(client => { client.BaseAddress = configuration.GatewayUri; });
        //    services.AddTransient<IEsdtTokenManager, EsdtTokenManager>();
        //    return services;
        //}
    }
}