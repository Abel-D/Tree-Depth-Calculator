using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Of_Branches.Tests
{
    public class TreeDepthCalculatorTests
    {
        [Fact]
        public void should_calculate_correct_depth()
        {
            //arrange
            Branch branch = new Branch()
            {
                branches = new List<Branch>() { }
            };

            //act
            var result = TreeDepthCalculator.CalculateTreeDepth(branch);

            //assert
            Assert.True(result == 1);
            Assert.IsAssignableFrom<int>(result);
        }
    }
}
