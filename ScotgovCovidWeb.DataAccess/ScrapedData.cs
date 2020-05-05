using System;

namespace ScotgovCovidWeb.DataAccess
{
    public partial class ScrapedData
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public int TotalTests { get; set; }
        public int PositiveTests { get; set; }
        public int NegativeTests { get; set; }
        public int TotalDeaths { get; set; }
        public int AyrshireandarranCases { get; set; }
        public int BordersCases { get; set; }
        public int DumfriesandgallowayCases { get; set; }
        public int FifeCases { get; set; }
        public int ForthvalleyCases { get; set; }
        public int GrampianCases { get; set; }
        public int GreaterglasgowandclydeCases { get; set; }
        public int HighlandCases { get; set; }
        public int LanarkshireCases { get; set; }
        public int LothianCases { get; set; }
        public int OrkneyCases { get; set; }
        public int ShetlandCases { get; set; }
        public int TaysideCases { get; set; }
    }
}
