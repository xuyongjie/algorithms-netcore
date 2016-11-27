using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    /// <summary>
    /// not completed
    /// </summary>
    class LeetCode464
    {
        //如果所选择的数可以重复的话，那么先选必输的情况就是 desiredTotal%(maxChoosableInteger+1)==0,其余则先选必赢
        //而此题所选不允许重复，就要复杂一些了
        public bool CanIWin(int maxChoosableInteger, int desiredTotal)
        {
            if(maxChoosableInteger>=desiredTotal)
            {
                return true;
            }
            if(desiredTotal>(maxChoosableInteger+1)*maxChoosableInteger/2)
            {
                return false;
            }

            return false;
        }
    }
}
