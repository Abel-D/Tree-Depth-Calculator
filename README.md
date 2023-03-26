#Tree-Of-Branches
This program app calculates the depth of a nested tree structure. 

## Structure

 public class Branch
    {
        public List<Branch>? branches;
    }
    
  ### Given Model
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
  #### Recursive calculation Logic 
  
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
