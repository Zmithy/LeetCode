using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution
    {

        int Rows = 0;
        int Columns = 0;
        int MaxArea = 0;
        public int MaxAreaOfIsland(int[][] grid)
        {

            Rows = grid.Length;
            Columns = grid[0].Length;

            // Array all 1?
            if (!grid.Any(r => r.Contains(0)))
                return Rows * Columns;

            // Array all 0?
            if (!grid.Any(c => c.Contains(1)))
                return 0;

            // Traverse Rows first
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {

                    // Check 1
                    if (grid[r][c] == 1)
                    {
                        var Searched = new HashSet<string>();
                        var Area = IslandDive(grid, r, c, Searched);
                        if (Area > MaxArea)
                            MaxArea = Area;
                    }
                }
            }


            return MaxArea;

        }

        public int IslandDive(int[][] grid, int r, int c, HashSet<string> Searched)
        {

            // Check  if border position (Outer colum)
            var rowInbounds = r >= 0 && r < Rows;
            var colInbounds = c >= 0 && c < Columns;
            if (!rowInbounds || !colInbounds)
                return 0;

            String pos = r + "," + c;
            if (Searched.Contains(pos))
                return 0;

            Searched.Add(pos);

            if (grid[r][c] == 0)
                return 0;

            // Dive on the other touching points
            int size = 1;
            // Recursive Call on bordering points
            size += IslandDive(grid, r + 1, c, Searched);
            size += IslandDive(grid, r - 1, c, Searched);
            size += IslandDive(grid, r, c + 1, Searched);
            size += IslandDive(grid, r, c - 1, Searched);

            return size;
        }
    }
}
