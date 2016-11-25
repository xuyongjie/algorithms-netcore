using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode463
    {
        public int IslandPerimeter(int[,] grid)
        {
            int row = grid.GetLength(0);
            int column = grid.GetLength(1);
            int[,] gridExtension = new int[row + 1, column + 1];

            int island = 0;
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<column;j++)
                {
                    if(grid[i,j]==1)
                    {
                        island++;
                    }
                    gridExtension[i, j] = grid[i, j];
                }
            }

            int duplicates = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    duplicates += GetDuplicate(gridExtension, i, j);
                }
            }
            return island * 4 - 2 * duplicates;
        }

        private int GetDuplicate(int[,] gridExtension, int i,int j)
        {
            int duplicate = 0;
            if(gridExtension[i,j]==1)
            {
                if(gridExtension[i,j+1]==1)
                {
                    duplicate++;
                }
                if(gridExtension[i+1,j]==1)
                {
                    duplicate++;
                }
            }
            return duplicate;
        }
    }
}
