using Microsoft.EntityFrameworkCore;
using RegistrationAPI.Models;

namespace RegistrationAPI.Data
{
   class RegistrationContext: DbContext
   {
    public DbSet<VaccinType> VaccinTypes { get; set; }

    public DbSet<VaccinationRegistration> VaccinationRegistrations { get; set; }
    
    public DbSet<VaccinationLocation> Vaccinationlocations { get; set; }

    
   }
}