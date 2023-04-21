using Microsoft.Extensions.Configuration;

    namespace Data.Config
    {
        public class ConfigurationHelper
        {
            public static IConfigurationRoot GetConfiguration()
            {
                var environments = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build()
                    .GetValue<string>("Environments")
                    ?.Split(";")
                    ?? throw new InvalidOperationException("Configuration value \"Environments\" is missing in appsettings.json.");

                var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")
                    ?? throw new InvalidOperationException($"Environment variable ASPNETCORE_ENVIRONMENT is not set.");

                if (!environments.Contains(environment))
                {
                    throw new ArgumentException("ASPNETCORE_ENVIROMENT is not set to a valid value.");
                }

                var configuration = new ConfigurationBuilder()
                          .SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile($"appsettings.json")
                          .Build();

                return configuration;
            }
        }
    }
