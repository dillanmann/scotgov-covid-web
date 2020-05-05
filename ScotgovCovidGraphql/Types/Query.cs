using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using ScotgovCovidWeb.DataAccess;
using System.Collections.Generic;

namespace ScotgovCovid.Web.Types
{
    /// <summary>
    /// GraphQL query class.
    /// </summary>
    public class Query
    {
        /// <summary>
        /// Get the datasets.
        /// </summary>
        /// <returns>List of data sets.</returns>
        [UsePaging]
        [UseSorting]
        public IEnumerable<ScrapedData> ScrapedDatasets([Service]ScotgovCovidStatsContext context)
            => context.Datasets;

        /// <summary>
        /// Get the datasets.
        /// </summary>
        /// <returns>List of data sets.</returns>
        [UsePaging]
        [UseSorting]
        public IEnumerable<CalculatedData> CalculatedDatasets([Service]ScotgovCovidStatsContext context)
            => context.CalculatedData;
    }
}
