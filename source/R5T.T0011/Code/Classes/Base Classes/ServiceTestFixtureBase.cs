using System;

using Microsoft.Extensions.DependencyInjection;


namespace R5T.T0011
{
    public abstract class ServiceTestFixtureBase<TService>
    {
        protected TService Service { get; private set; }


        public ServiceTestFixtureBase(IServiceProvider serviceProvider)
        {
            this.Service = serviceProvider.GetRequiredService<TService>();
        }
    }
}
