using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Of_Branches
{
    internal static class TreeDepthCalculator
    {
        static int temp = 1;
        static int depth = 0;

        public static int CalculateTreeDepth(Branch branch)
        {
            foreach (var br in branch.branches)
            {

                while (br.branches != null)
                {
                    temp++;
                    CalculateTreeDepth(br);
                }
                if (temp > depth)
                {
                    depth = temp;
                }
            }
            return depth;
        }
    }
}
