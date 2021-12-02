using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoMath
{
    class GeoOp
    {
        public int OperOne(int a)           // ADD OPERATION
        {
            return a + a;
        }
        public int OperTwo(int a)           // MULTIPLY OPERATION
        {
            return a - 2;
        }
        public int OperThree(int a)         // MODULUS
        {
            return a % 7;
        }
    }
}
