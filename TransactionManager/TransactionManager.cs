using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManager
{
    public class TransactionManager
    {

        public decimal CalculateFullPrice(decimal transaction)
        {
            if (transaction < 10)
                throw new ArgumentException("Minimum amount is 10");
            else if (transaction > 1000000m)
                throw new ArgumentException("Maximum amount is 1 000 000");
            decimal fullPrice;
            if (transaction >= 10 && transaction <= 999)
            {
                fullPrice = transaction + transaction * 0.1m;
            }
            else if (transaction >= 1000 && transaction <= 9999)
            { 
                fullPrice = transaction + transaction * 0.05m; 
            }
            else
            {
                fullPrice = transaction + transaction * 0.01m;
            }

            return fullPrice;
        }
    }
}
