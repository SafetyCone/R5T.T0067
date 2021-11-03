using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;
using R5T.T0067;


namespace System
{
    public static class IServiceOperatorExtensions
    {
        public static ServiceProvider GetServiceInstance<TService>(this IServiceOperator _,
            IServiceAction<TService> serviceAction,
            out TService instance)
        {
            var services = new ServiceCollection();

            var output = services.GetInstance(
                serviceAction,
                out instance);

            return output;
        }
    }
}