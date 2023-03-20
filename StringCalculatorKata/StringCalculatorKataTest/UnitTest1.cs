using StringCalculatorKata;

namespace StringCalculatorKataTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_EmptyStringAsParam_ReturnsZero()
        {
            //arrange
            int result = StringCalculator.Add("");
            //act

            //assert
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void Add_StringContainingSingleNumber_ReturnsTheNumberItself()
        {
            //arrange
            int result2 = StringCalculator.Add("3");
            //act

            //assert
            Assert.AreEqual(3, result2);
        }
        [TestMethod]
        public void Add_TwoNumbersSeparatedByComma_ReturnsTheirSum()
        {
            //arrange
            int result3 = StringCalculator.Add("34");
            //act

            //assert
            Assert.AreEqual(34, result3);
        }
        [TestMethod]
        public void Add_MoreThanThreeNumbersSeparatedByComma_ReturnsTheirSum()
        {
            //arrange
            int result4 = StringCalculator.Add("34654");
            //act

            //assert
            Assert.AreEqual(34654, result4);
        }
    }
}