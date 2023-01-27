using CsvHelper;
using CsvHelper.Configuration.Attributes;
using CsvHelper.TypeConversion;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndStateCensusAnalyser
{
    public class StateCensusAnalyser
    {
        public int b = 0;
        public int ReadingCSVFile()
        {
            string CSVPath = @"C:\Users\Hp\Desktop\240\IndStateCensusAnalyser\IndStateCensusAnalyser\CSVStateCensus.csv";
            try
            {
                using (var r = new StreamReader(CSVPath))
                using (var csv = new CsvReader(r, CultureInfo.InvariantCulture))
                {
                    var CSVrecords = csv.GetRecords<AddressData>().ToList();
                    Console.WriteLine("*****State Census Data in CSV File*****");
                    Console.WriteLine("FREQUENCY,DATE,LOCATION_NAME,LOCATION_F5,LOCATION_ID,LOCATION_REGIONID,VARIABLE_NAME,VALUE,VARIABLE_ID");
                    foreach (AddressData i in CSVrecords)
                    {
                        Console.WriteLine(i.FREQUENCY + "," + i.DATE + "," + i.LOCATION_NAME + "," + i.LOCATION_F5 + "," + i.LOCATION_ID + "," + i.LOCATION_REGIONID + "," + i.VARIABLE_NAME + "," + i.VALUE + "," + i.VARIABLE_ID);
                    }
                    return b = CSVrecords.Count;
                }
            }
            catch (CustomException)
            {              
                    throw new CustomException(CustomException.ExceptionType.RECORD_NOT_MATCH, "Record Not Match");
            }
            catch (TypeConverterException)
            {
                throw new CustomException(CustomException.ExceptionType.INCORRECT_TYPE, "Incorrect type");
            }
                  
            return b;
        }
    }
}
