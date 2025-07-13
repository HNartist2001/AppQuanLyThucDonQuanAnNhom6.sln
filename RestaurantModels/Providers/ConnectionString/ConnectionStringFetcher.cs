using Microsoft.Extensions.Configuration;
using RestaurantLibrary.ApplicationLauncher.StartUpStep.TheSteps.ConfigBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary.Providers.ConnectionString
{
    public class ConnectionStringFetcher:IConnectionStringProvider
    {
        string _StringName;
        IConfigBuilder _config;
        private string? _cachedConnectionString;

        public ConnectionStringFetcher(string StringName, IConfigBuilder config) 
        {
            _StringName = StringName;
            _config = config;
        }


        public string GetConnectionString()
        {
            if (_cachedConnectionString != null)
                return _cachedConnectionString;

            IConfiguration config = _config.ReturnConfig(Bridge._Anchor);
            _cachedConnectionString = config[$"{_StringName}"];

            return _cachedConnectionString ?? throw new InvalidOperationException($"Connection string '{_StringName}' not found.");
        }
    }
}
