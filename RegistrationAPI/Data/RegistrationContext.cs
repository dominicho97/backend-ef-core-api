using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RegistrationAPI.Configuration;
using RegistrationAPI.Models;

namespace RegistrationAPI.Data
{
   class RegistrationContext: DbContext
   {
    public DbSet<VaccinType> VaccinTypes { get; set; }

    public DbSet<VaccinationRegistration> VaccinationRegistrations { get; set; }
    
    public DbSet<VaccinationLocation> Vaccinationlocations { get; set; }

    private ConnectionStrings _connectionStrings; 

    public RegistrationContext(DbContextOptions<RegistrationContext>options,IOptions<ConnectionStrings> connectionstrings)
    {
        _connectionStrings = connectionstrings.Value;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_connectionStrings.SQL);
        }
    
   }
}