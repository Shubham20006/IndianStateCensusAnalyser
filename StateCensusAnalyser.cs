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
            string CSVPath = @"C:\Users\Hp\Desktop\240\IndStateCensusAnalyser\IndStateCensusAnalyser\StateCSV.csv";
            try
            {
                using (var r = new StreamReader(CSVPath))
                using (var csv = new CsvReader(r, CultureInfo.InvariantCulture))
                {
                    var CSVrecords = csv.GetRecords<AddressData>().ToList();
                    Console.WriteLine("*****State Census Data in CSV File*****");
                    Console.WriteLine("SrNo,StateName,TIN,StateCode");
                    foreach (AddressData i in CSVrecords)
                    {
                        Console.WriteLine(i.SrNo + "," + i.StateName + "," + i.TIN + "," + i.StateCode);
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
            catch (HeaderValidationException)
            {
                throw new CustomException(CustomException.ExceptionType.INCORRECT_HEADER, "Incorrect Header");
            }
            catch (Exception)
            {
                throw new CustomException(CustomException.ExceptionType.INCORRECT_DELIMITER, "INCORRECT DELIMITER");
            }

            return b;
        }
    }
}
