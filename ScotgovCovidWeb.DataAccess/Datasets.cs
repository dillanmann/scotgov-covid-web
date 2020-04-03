using System;
using System.Collections.Generic;

namespace ScotgovCovidWeb.DataAccess
{
    public partial class Datasets
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public int TotalTests { get; set; }
        public int PositiveTests { get; set; }
        public int NegativeTests { get; set; }
        public int TotalDeaths { get; set; }
        public int AyrshireandarranDeaths { get; set; }
        public int BordersDeaths { get; set; }
        public int DumfriesandgallowayDeaths { get; set; }
        public int FifeDeaths { get; set; }
        public int ForthvalleyDeaths { get; set; }
        public int GrampianDeaths { get; set; }
        public int GreaterglasgowandclydeDeaths { get; set; }
        public int HighlandDeaths { get; set; }
        public int LanarkshireDeaths { get; set; }
        public int LothianDeaths { get; set; }
        public int OrkneyDeaths { get; set; }
        public int ShetlandDeaths { get; set; }
        public int TaysideDeaths { get; set; }
    }
}
