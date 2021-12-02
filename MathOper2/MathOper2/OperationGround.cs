using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOper2
{
    class OperationGround
    {
        public int ExchangeRate(int a, int b = 1)       // DECLARATION OF A METHOD WITH ONE OPCIONAL PARAMETER
        {
            return (a * 100) / (b + 1);
        }
    }
}
