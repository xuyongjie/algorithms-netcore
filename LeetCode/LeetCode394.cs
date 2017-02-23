using System.Collections.Generic;
using System.Text;

namespace Algorithmsnetcore.LeetCode
{
    //AC栈实现
    public class LeetCode394
    {
        public string DecodeString(string s)
        {
            s="1["+s+"]";
            Stack<int> numberStack=new Stack<int>();
            Stack<string> stringStack=new Stack<string>();
            int number=0;
            StringBuilder builder=new StringBuilder();
            for(int i=0;i<s.Length;i++)
            {
                if(IsDigit(s[i]))
                {
                    if(builder.Length>0)
                    {
                        stringStack.Push(builder.ToString());
                        builder.Clear();
                    }
                    number=number*10+s[i]-'0';
                }else if(s[i]=='['){
                    numberStack.Push(number);
                    number=0;
                    stringStack.Push("[");
                }else if(s[i]==']')
                {
                    if(builder.Length>0)
                    {
                        stringStack.Push(builder.ToString());
                        builder.Clear();
                    }
                    int headNumber=numberStack.Pop();
                    StringBuilder tempBuilder=new StringBuilder();
                    string headString=stringStack.Pop();
                    while(!headString.Equals("["))
                    {
                        tempBuilder.Insert(0,headString);
                        headString=stringStack.Pop();
                    }
                    string tempString=tempBuilder.ToString();
                    tempBuilder.Clear();
                    while(headNumber>0)
                    {
                        tempBuilder.Append(tempString);
                        headNumber--;
                    }
                    stringStack.Push(tempBuilder.ToString());
                }else{
                    builder.Append(s[i]);
                }
            }
            StringBuilder resultBuilder=new StringBuilder();
            while(stringStack.Count>0)
            {
                resultBuilder.Insert(0,stringStack.Pop());
            }
            return resultBuilder.ToString();
        }

        private bool IsDigit(char c)
        {
            return c>='0'&&c<='9';
        }
    }
}