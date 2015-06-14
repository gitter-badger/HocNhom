using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_QuangTran
{
    class QMath
    {
        //GiaiThua(3) = 3*2*1=6
        //3*GiaiThua(3-1) = 3*2*1=6
        //GiaiThua(5) = 5*4*3*2*1=120
        //5*GiaiThua(5-1)
        //5*4*GiaiThua(4-1)
        //5*4*3*GiaiThua(3-1)
        public static int GiaiThua(int n)
        {
            if (n == 0) {
                return 1;
            }

            return n * GiaiThua(n - 1);
        }

        //LuyThua(2,3)
        //2*LuyThua(2,3-1)
        //2*2*LuyThua(2,2-1)
        //2*2*1*LuyThua(2,1-1)
        public static int LuyThua(int a, int n)
        {
            if (a == 0)
            {
                return 0;
            }
            if (n == 0)
            {
                return 1;
            }

            return a * LuyThua(a,n-1);
        }
    }
}
