using Microsoft.Extensions.DependencyInjection;
using ScriptPortal.Vegas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wz.VegasToolkit.Core
{
    public abstract class VegasScriptBootstrapper
    {
        private readonly Vegas _vegas;

        protected VegasScriptBootstrapper(Vegas vegas)
        {
            this._vegas = vegas;
        }

        protected IServiceProvider ServiceProvider { get; set; }

        public void Run()
        {
            IServiceCollection service = new ServiceCollection();

            ConfigureServices(service);

            ServiceProvider = service.BuildServiceProvider();

            OnStartup();
        }

        protected virtual void OnStartup()
        {
        }

        protected virtual void ConfigureServices(IServiceCollection service)
        {
            service.AddSingleton(_vegas);
        }
    }
}
