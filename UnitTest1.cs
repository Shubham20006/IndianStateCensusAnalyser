using IndStateCensusAnalyser;
using NUnit.Framework.Internal;

namespace StateCensusDataTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodHAPPY()
        {
            StateCensusAnalyser SC=new StateCensusAnalyser();
            int expected = 37;
            int actual=SC.ReadingCSVFile();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodSAD()
        {
            StateCensusAnalyser SC = new StateCensusAnalyser();
            string expected = "Record Not Match";
            try
            {
                int actual = SC.ReadingCSVFile();              
            }catch(CustomException actual)
            {
                Assert.AreEqual(expected, actual);
            }

        }
        [TestMethod]
        public void TestMethodSAD1()
        {
            StateCensusAnalyser SC = new StateCensusAnalyser();
            string expected = "Incorrect Type";
            try
            {
                int actual = SC.ReadingCSVFile();
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }

        }
        [TestMethod]
        public void TestMethodSAD2()
        {
            StateCensusAnalyser SC = new StateCensusAnalyser();
            string expected = "Incorrect Header";
            try
            {
                int actual = SC.ReadingCSVFile();
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }

        }
        [TestMethod]
        public void TestMethodSAD3()
        {
            StateCensusAnalyser SC = new StateCensusAnalyser();
            string expected = "INCORRECT DELIMITER";
            try
            {
                int actual = SC.ReadingCSVFile();
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }

        }
    }
}