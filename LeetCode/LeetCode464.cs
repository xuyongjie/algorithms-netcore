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
        public bool CanIWin(int maxChoosableInteger, int desiredTotal)
        {
            if(maxChoosableInteger>=desiredTotal)
            {
                return true;
            }
            return false;

        }
    }
}
