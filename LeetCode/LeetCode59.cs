using System;

namespace Algorithmsnetcore.LeetCode
{
    // Given an integer n, generate a square matrix filled with elements from 1 to n2 in spiral order.

    // For example,
    // Given n = 3,

    // You should return the following matrix:
    // [
    //  [ 1, 2, 3 ],
    //  [ 8, 9, 4 ],
    //  [ 7, 6, 5 ]
    // ]
    // Subscribe to see which companies asked this question.

    //AC,分圈赋值，每圈四个方向
    public class LeetCode59
    {
        public int[,] GenerateMatrix(int n)
        {
            int[,] result=new int[n,n];
            int start=1;
            for(int i=0;i<(n+1)/2;i++)
            {
                //left to right
                for(int column=i;column<n-i;column++)
                {
                    result[i,column]=start++;
                }
                //up to bottom
                for(int row=i+1;row<n-i;row++)
                {
                    result[row,n-i-1]=start++;
                }
                //right to left
                for(int column=n-i-2;column>=i;column--)
                {
                    result[n-i-1,column]=start++;
                }
                //bottom to up
                for(int row=n-i-2;row>i;row--)
                {
                    result[row,i]=start++;
                }
            }
            return result;
        }
    }
}