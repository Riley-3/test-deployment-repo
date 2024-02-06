namespace Riley033.TestDeploymentRepo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(1, 3, 4)]
        [DataRow(-1, 1, 0)]
        public void TestMethod1(int x, int y, int expected)
        {
            Assert.AreEqual(expected, Class1.Add(x, y));
        }
    }
}