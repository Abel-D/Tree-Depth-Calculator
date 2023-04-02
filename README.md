# Tree-Of-Branches
  This project library contains app logic to calculate the depth of a nested tree structure. 
## Structure
       public class Branch
          {
              public List<Branch>? branches;
          }
  ### Test Model
   ![sample used structure](https://github.com/Abel-D/Tree-Depth-Calculator/blob/master/img/tree.PNG)
    
    // Root node of the tree
        Branch root = new Branch()
        {
          branches = new List<Branch>()
            {
                //left outer most
                new Branch()
                {
                    branches = new List<Branch>()
                    {
                        new Branch()
                    }
                },
                // root's right branch
                new Branch()
                {
                    branches = new List<Branch>()
                    {
                        // right nodes left outermost
                        new Branch()
                        {
                            branches = new List<Branch>()
                            {
                                new Branch()
                            }
                        },
                        // right node middle branch
                        new Branch()
                        {
                            branches = new List<Branch>()
                            {
                                //middle node left branch
                                new Branch()
                                {
                                    branches = new List<Branch>()
                                    {
                                        new Branch()
                                        {
                                            branches= new List<Branch>()
                                            {
                                                new Branch()
                                                {
                                                    branches =new List<Branch>(){}
                                                }
                                            }
                                        }
                                    }
                                },
                                //middle node right branch
                                new Branch()
                                {
                                    branches=new List<Branch>(){}
                                }
                            }
                        },
                        //right outermost branch
                        new Branch() { branches = new List<Branch>()
                    }
                }
           }
    }
};
 ### Recursive calculation Logic 
  #### namespace Tree_Of_Branches
        static int temp = 1;
        static int depth = temp;

      CalculateTreeDepth(Branch branch)
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
 ## Tree-Of-Branchs.Test
 This is a xunit test project for the above implementation logic.
        
   #### namespace Tree_Of_Branches.Tests
        void should_calculate_correct_depth()
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
   
