using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Of_Branches
{
    public static class TreeDepthCalculator
    {
        static int temp = 1;
        static int depth = temp;

        public static int CalculateTreeDepth(Branch branch)
        {
           foreach (var br in branch.branches)
            {

                if (br.branches != null)
                {
                    temp++;
                    CalculateTreeDepth(br);
                }
                if (temp > depth)
                {
                    depth = temp;
                }
                temp = 1;
            }
            return depth;
        }
    }
}
