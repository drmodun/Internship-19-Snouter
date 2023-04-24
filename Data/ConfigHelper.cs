using Microsoft.Extensions.Configuration;

    namespace Data.Config
    {
        public class ConfigurationHelper
        {
            public static IConfigurationRoot GetConfiguration()
            {
               
                var configuration = new ConfigurationBuilder()
                          .SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile($"appsettings.json")
                          .Build();

                return configuration;
            }
        }
    }
