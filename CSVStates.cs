using CsvHelper.TypeConversion;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndStateCensusAnalyser
{
    public class CSVStates
    {
       
        public static int ReadingStateCode()
        {
            string Path = @"C:\Users\Hp\Desktop\240\IndStateCensusAnalyser\IndStateCensusAnalyser\StateCSV.csv";
            try
            {
                using (var r = new StreamReader(Path))
                using (var csv = new CsvReader(r, CultureInfo.InvariantCulture))
                {
                    var CSVrecords = csv.GetRecords<AddressData>().ToList();
                    Console.WriteLine("*****State Census Data in CSV File*****");
                    Console.WriteLine("StateCodes");
                    foreach (AddressData i in CSVrecords)
                    {
                        Console.WriteLine( i.StateCode);
                    }
                    return CSVrecords.Count;
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
            catch (HeaderValidationException)
            {
                throw new CustomException(CustomException.ExceptionType.INCORRECT_HEADER, "Incorrect Header");
            }
            //catch (Exception)
            //{
            //    throw new CustomException(CustomException.ExceptionType.INCORRECT_DELIMITER, "INCORRECT DELIMITER");
            //}

            
        }
    }
}

