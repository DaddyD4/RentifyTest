namespace rentify;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using Microsoft.EntityFrameworkCore;
public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        // Use the connection string from appsettings.json
        var connectionString = Configuration.GetConnectionString("CondoRentalContext");

        // Configure your database context with the connection string
        //services.AddDbContext<CondoRentalContext>(options =>
            //options.UseSqlServer(connectionString));
    }

    // Other configuration and setup methods...
}
