using System.Text;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode38
    {
        public string CountAndSay(int n)
        {
            string result="1";
            while(n>1)
            {
                result=CountAndSayString(result);
                n--;
            }
            return result;
        }

        private string CountAndSayString(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            StringBuilder sb=new StringBuilder();
            char number=s[0];
            int count=1;
            for(int i=1;i<s.Length;i++)
            {
                if(s[i]!=number)
                {
                    sb.Append(count).Append(number);
                    number=s[i];
                    count=1;
                }else{
                    count++;
                }
            }
            sb.Append(count).Append(number);
            return sb.ToString();
        }
    }
}