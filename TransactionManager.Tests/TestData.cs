using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManager.Tests
{
    public class TestData
    {
        public static IEnumerable<TestCaseData> TestValidTransactionData ()
        {
            yield return new TestCaseData (10000m, 10100m);
            yield return new TestCaseData (100000m, 101000m);
            yield return new TestCaseData (50m, 55m);
            yield return new TestCaseData (1000m, 1050m);
            yield return new TestCaseData (2000m, 2100m);
            yield return new TestCaseData (10m, 11m);
        }

        public static IEnumerable<TestCaseData> TestInvalidTransactionData()
        {
            yield return new TestCaseData(9m, "Minimum amount is 10");
            yield return new TestCaseData(1_000_000m, "Maximum amount is 1 000 000");

        }
    }
}
