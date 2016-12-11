using System;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode64
    {
        public int MinPathSum(int[,] grid)
        {
            int row=grid.GetLength(0);
            int column=grid.GetLength(1);
            int[,] MIN=new int[row,column];
            MIN[0,0]=grid[0,0];
            for(int i=1;i<column;i++)
            {
                MIN[0,i]=MIN[0,i-1]+grid[0,i];
            }
            for(int i=1;i<row;i++)
            {
                MIN[i,0]=MIN[i-1,0]+grid[i,0];                
            }
            for(int i=1;i<row;i++)
            {
                for(int j=1;j<column;j++)
                {
                    MIN[i,j]=Math.Min(MIN[i,j-1],MIN[i-1,j])+grid[i,j];
                }
            }
            return MIN[row-1,column-1];
        }
    }
}