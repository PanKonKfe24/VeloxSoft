using Microsoft.Extensions.Configuration;

namespace VeloxSoft.Config
{
    public class DatabaseConfig
    {
        private readonly IConfiguration _configuration;

        public DatabaseConfig(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnection(Roles role)
        {
            return _configuration.GetConnectionString(role.ToString());
        }
    }
}