


namespace TransactionManager.Tests
{
    [TestFixture]
    public class CalculationTests
    {
        TransactionManager Transaction;
        [SetUp]
        public void PreConditions ()
        {
            Transaction = new TransactionManager ();
        }

        [Test]
        [TestCaseSource(typeof(TestData),nameof(TestData.TestValidTransactionData))]
        public void TestValidTransaction(decimal transaction, decimal expected)
        {
            var actualResult = Transaction.CalculateFullPrice(transaction);

            Assert.True(actualResult == expected);

        }

        [Test]
        [TestCaseSource(typeof(TestData), nameof(TestData.TestInvalidTransactionData))]
        public void TestInvalidTransaction(decimal transaction, string expectedMessage)
        {
            try 
            {
                var actualResult = Transaction.CalculateFullPrice(transaction);
            }
            catch (ArgumentException ex)
            {
                Assert.IsTrue(ex.Message == expectedMessage);
            }
            
        }
    }
}
