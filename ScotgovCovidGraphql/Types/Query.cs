using ScotgovCovid.Shared;
using ScotgovCovidWeb.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScotgovCovidGraphql.Types
{
   public class Query
   {
      private readonly ScotgovCovidStatsContext context;
      public Query(ScotgovCovidStatsContext context)
      {
         this.context = context ?? throw new ArgumentNullException(nameof(context));
      }

      public IEnumerable<Dataset> Datasets()
      {
         return this.context.Datasets;
      }
   }
}
