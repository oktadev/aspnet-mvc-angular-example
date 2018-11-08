using System.Data.Entity;
using OktaAspNetMvcAngular.Models;

namespace OktaAspNetMvcAngular.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("OktaConnectionString")
        {
        }

        public static ApplicationDbContext Create() => new ApplicationDbContext();

	    public DbSet<JoggingRecord> JoggingRecords { get; set; }
    }
}