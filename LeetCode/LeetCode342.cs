using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode342
    {
        public bool IsPowerOfFour(int num)
        {
            if(num<=0)
            {
                return false;
            }
            while(num%4==0)
            {
                num = num / 4;
            }
            if(num==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
