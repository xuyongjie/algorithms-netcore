using System;
using System.Collections.Generic;

namespace Algorithmsnetcore
{
    //算符优先分析法
    //支持计算+、-、*、／、（、），暂不支持操作负数的情况，若想支持，可以在前面字符非数字的负号前插入0
    //再用该分析法求值
    class SimpleCalculator
    {
        private Stack<char> op;//操作符栈
        private Stack<int> optor;//操作数栈
        //"(1+(4+5+2)-3)+(6+8)"
        public int Calculate(string s)
        {
            s = "\"" + s + "\"";
            op = new Stack<char>();
            optor = new Stack<int>();
            int num = 0;
            bool numSplited = false;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == ' ')
                {
                    continue;
                }
                if (IsNumber(c))
                {
                    numSplited = true;
                    num = num * 10 + (c - '0');
                }
                else
                {
                    if (numSplited)
                    {
                        optor.Push(num);
                        numSplited = false;
                        num = 0;
                    }
                    if (IsOp(c))
                    {
                        if (op.Count <= 0)
                        {
                            op.Push(c);
                        }
                        else
                        {
                            while (true)
                            {
                                char op1 = op.Peek();
                                char relation = Compare(op1, c);
                                switch (relation)
                                {
                                    case 'e':
                                        break;
                                    case '>':
                                        op1 = op.Pop();
                                        if (optor.Count >= 2)
                                        {
                                            int num1 = optor.Pop();
                                            int num2 = optor.Pop();
                                            switch (op1)
                                            {
                                                case '+':
                                                    optor.Push(num1 + num2);
                                                    break;
                                                case '-':
                                                    optor.Push(num2 - num1);
                                                    break;
                                                case '*':
                                                    optor.Push(num1 * num2);
                                                    break;
                                                case '/':
                                                    optor.Push(num2 / num1);
                                                    break;
                                            }
                                            continue;
                                        }
                                        break;
                                }
                                if (c == ')')
                                {
                                    op.Pop();
                                }
                                else
                                {
                                    op.Push(c);
                                }
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("expression error");
                    }
                }
            }
            if (optor.Count > 0)
            {
                return optor.Pop();
            }
            else
            {
                return 0;
            }
        }

        private bool IsNumber(char c)
        {
            return '0' <= c && c <= '9';
        }

        private bool IsOp(char c)
        {
            if (c == '"' || c == '+' || c == '-' || c == '(' || c == ')'||c=='*'||c=='/')
            {
                return true;
            }
            return false;
        }


        // # + - ( )
        //返回> < = 或者  e代表表达式异常
        private char Compare(char op1, char op2)
        {
            if (op1 == '"' && op2 == '"')
            {
                return 'e';
            }
            else if (op1 == '"' && op2 == '+')
            {
                return '<';
            }
            else if (op1 == '"' && op2 == '-')
            {
                return '<';
            }
            else if (op1 == '"' && op2 == '*')
            {
                return '<';
            }
            else if (op1 == '"' && op2 == '/')
            {
                return '<';
            }
            else if (op1 == '"' && op2 == '(')
            {
                return '<';
            }
            else if (op1 == '"' && op2 == ')')
            {
                return 'e';
            }
            else if (op1 == '+' && op2 == '"')
            {
                return '>';
            }
            else if (op1 == '+' && op2 == '+')
            {
                return '>';
            }
            else if (op1 == '+' && op2 == '-')
            {
                return '>';
            }
            else if (op1 == '+' && op2 == '*')
            {
                return '<';
            }
            else if (op1 == '+' && op2 == '/')
            {
                return '<';
            }
            else if (op1 == '+' && op2 == '(')
            {
                return '<';
            }
            else if (op1 == '+' && op2 == ')')
            {
                return '>';
            }
            else if (op1 == '-' && op2 == '"')
            {
                return '>';

            }
            else if (op1 == '-' && op2 == '+')
            {
                return '>';

            }
            else if (op1 == '-' && op2 == '-')
            {
                return '>';

            }
            else if (op1 == '-' && op2 == '*')
            {
                return '<';

            }
            else if (op1 == '-' && op2 == '/')
            {
                return '<';

            }
            else if (op1 == '-' && op2 == '(')
            {
                return '<';

            }
            else if (op1 == '-' && op2 == ')')
            {
                return '>';

            }
            else if (op1 == '*' && op2 == '"')
            {
                return '>';

            }
            else if (op1 == '*' && op2 == '+')
            {
                return '>';

            }
            else if (op1 == '*' && op2 == '-')
            {
                return '>';

            }
            else if (op1 == '*' && op2 == '*')
            {
                return '>';

            }
            else if (op1 == '*' && op2 == '/')
            {
                return '>';

            }
            else if (op1 == '*' && op2 == '(')
            {
                return '<';

            }
            else if (op1 == '*' && op2 == ')')
            {
                return '>';

            }
            else if (op1 == '/' && op2 == '"')
            {
                return '>';

            }
            else if (op1 == '/' && op2 == '+')
            {
                return '>';

            }
            else if (op1 == '/' && op2 == '-')
            {
                return '>';

            }
            else if (op1 == '/' && op2 == '*')
            {
                return '>';

            }
            else if (op1 == '/' && op2 == '/')
            {
                return '>';

            }
            else if (op1 == '/' && op2 == '(')
            {
                return '<';

            }
            else if (op1 == '/' && op2 == ')')
            {
                return '>';

            }
            else if (op1 == '(' && op2 == '"')
            {
                return 'e';

            }
            else if (op1 == '(' && op2 == '+')
            {
                return '<';

            }
            else if (op1 == '(' && op2 == '-')
            {
                return '<';

            }
            else if (op1 == '(' && op2 == '*')
            {
                return '<';

            }
            else if (op1 == '(' && op2 == '/')
            {
                return '<';

            }
            else if (op1 == '(' && op2 == '(')
            {
                return '<';
            }
            else if (op1 == '(' && op2 == ')')
            {
                return '<';
            }
            else if (op1 == ')' && op2 == '"')
            {
                return '>';

            }
            else if (op1 == ')' && op2 == '+')
            {
                return '>';

            }
            else if (op1 == ')' && op2 == '-')
            {
                return '>';

            }
            else if (op1 == ')' && op2 == '*')
            {
                return '>';

            }
            else if (op1 == ')' && op2 == '/')
            {
                return '>';

            }
            else if (op1 == ')' && op2 == '(')
            {
                return 'e';

            }
            else if (op1 == ')' && op2 == ')')
            {
                return '>';
            }
            return 'e';
        }
    }
}