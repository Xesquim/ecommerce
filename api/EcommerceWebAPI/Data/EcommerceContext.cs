using Microsoft.EntityFrameworkCore;

namespace EcommerceWebAPI.Data
{
    public class EcommerceContext : DbContext
    {
        protected readonly IConfiguration _configuration;

        public EcommerceContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_configuration.GetConnectionString("default"));
        }
    }
}
