using System;
using System.Collections.Generic;

namespace ScotgovCovidWeb.DataAccess
{
    public partial class CalculatedData
    {
        public DateTime Date { get; set; }
        public int DailyDeaths { get; set; }
    }
}
