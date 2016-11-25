using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode{
    public class LeetCode451 {
    public string FrequencySort(string s) {
        Dictionary<char,int> dic=new Dictionary<char,int>();
        foreach (var c in s)
        {
            if(dic.ContainsKey(c))
            {
                dic[c]++;
            }else
            {
                dic.Add(c,1);
            }
        }
        var sorted=dic.OrderByDescending(v => v.Value);
        StringBuilder builder = new StringBuilder();
        foreach(var item in sorted)
        {
            int val = item.Value;
            while(val>0)
            {
                builder.Append(item.Key);
                val--;
            }
        }
        return builder.ToString();
    }
}
}
