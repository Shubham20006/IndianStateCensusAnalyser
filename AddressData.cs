using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndStateCensusAnalyser
{
    public class AddressData
    {
        public string FREQUENCY { get; set; }
        public string DATE { get; set; }
        public string LOCATION_NAME { get; set; }
        public string LOCATION_F5 { get; set; }
        public string LOCATION_ID { get; set; }
        public string LOCATION_REGIONID { get; set; }
        public string VARIABLE_NAME { get; set; }
        public string VALUE { get; set; }
        public string VARIABLE_ID { get; set; }
    }
}
//FREQUENCY; DATE; LOCATION_NAME; LOCATION_F5; LOCATION_ID; LOCATION_REGIONID; VARIABLE_NAME; VALUE; VARIABLE_ID