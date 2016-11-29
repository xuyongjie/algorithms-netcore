using System;
using System.Collections.Generic;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode210
    {
        bool[] done;
        bool[] prerequisitesDeleted;
        public int[] FindOrder(int numCourses, int[,] prerequisites)
        {
            List<int> result = new List<int>();
            done = new bool[numCourses];
            prerequisitesDeleted = new bool[prerequisites.GetLength(0)];
            while (true)
            {
                bool hasInRadiusZero = false;
                for (int i = 0; i < numCourses; i++)
                {
                    if (!done[i] && IsInRadiusZero(i, prerequisites))
                    {
                        done[i] = true;
                        hasInRadiusZero = true;
                        result.Add(i);
                        Delete(i, prerequisites);
                        break;
                    }
                }
                if (!hasInRadiusZero)
                {
                    break;
                }
            }
            if (result.Count == numCourses)
            {
                return result.ToArray();
            }
            else
            {
                return new int[0];
            }
        }
        //入度是否为0
        private bool IsInRadiusZero(int course, int[,] prerequisites)
        {
            for (int i = 0; i < prerequisites.GetLength(0); i++)
            {
                if (!prerequisitesDeleted[i])
                {
                    if (prerequisites[i, 0] == course)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void Delete(int course, int[,] prerequisites)
        {
            for (int i = 0; i < prerequisites.GetLength(0); i++)
            {
                if (prerequisites[i, 1] == course)
                {
                    prerequisitesDeleted[i] = true;
                }
            }
        }
    }
}