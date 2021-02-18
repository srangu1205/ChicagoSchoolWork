using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChicagoSchoolsAPI.Models
{
    public class SchoolPercentageResults
    {
        public string SchoolId { get; set; }
        public string SchoolShortName { get; set; }
        public double StudentCount { get; set; }
        public double StudentCountBlack { get; set; }
        public double StudentCountHispanic { get; set; }
        public double StudentCountWhite { get; set; }
        public double StudentCountAsian { get; set; }
        public double StudentCountNativeAmerican { get; set; }
        public double StudentCountAsianPacificIslander { get; set; }
        public double StudentCountMultiEthnic { get; set; }
        public double StudentCountHawaiianPacificIslander { get; set; }
        public double StudentCountEthnicityOther { get; set; }
        public double StudentCountEthnicityUnavailable { get; set; }
    }
}