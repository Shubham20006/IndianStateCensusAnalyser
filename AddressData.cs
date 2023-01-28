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
        public string SrNo { get; set; }
        public string StateName { get; set; }
        public string TIN { get; set; }
        public string StateCode { get; set; }
        //SrNo,StateName,TIN, StateCode
    }
}
