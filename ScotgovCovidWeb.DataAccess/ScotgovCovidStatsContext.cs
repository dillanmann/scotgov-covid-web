using Microsoft.EntityFrameworkCore;
using ScotgovCovid.Shared;

namespace ScotgovCovidWeb.DataAccess
{
   public class ScotgovCovidStatsContext : DbContext
   {
      public ScotgovCovidStatsContext(DbContextOptions<ScotgovCovidStatsContext> options)
         : base(options)
      {
      }

      public DbSet<Dataset> Datasets { get; set; }
   }
}
