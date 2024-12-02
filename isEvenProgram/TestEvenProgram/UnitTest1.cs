namespace TestEvenProgram
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(2)]
        [DataRow(4)]
        public void IsEven(int num)
        {
            bool IsEven;

            IsEven = IsEvenProgram.Program.IsEven(num);

            Assert.IsTrue(IsEven);
        }
    }
}