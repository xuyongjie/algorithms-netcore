using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithmsnetcore.LeetCode
{
    //递归遍历，回溯
    public class LeetCode93
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            List<string> okIps = new List<string>();
            Handle(s, 0, 0, okIps);
            return okIps;
        }

        private List<string> okIp= new List<string>();
        private void Handle(string s, int start, int okCount, List<string> okIps)
        {
            if (start == s.Length && okCount == 4)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 4; i++)
                {
                    if (i == 3)
                    {
                        sb.Append(okIp[i]);
                    }
                    else
                    {
                        sb.Append(okIp[i]).Append('.');
                    }
                }
                okIps.Add(sb.ToString());
                //ok;
                return;
            }

            if (start < s.Length && okCount < 4)
            {
                for (int i = 1; i <= 3 && i <= s.Length - start; i++)
                {
                    string temp = s.Substring(start, i);
                    if (EachValidate(temp))
                    {
                        okIp.Add(temp);
                        Handle(s, start + i, okCount + 1, okIps);
                        okIp.RemoveAt(okIp.Count-1);
                    }
                }
            }
        }

        private bool EachValidate(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length > 3)
            {
                return false;
            }
            if (s[0] == '0')
            {
                if (s.Length > 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                int i = int.Parse(s);
                if (i > 0 && i <= 255)
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
}