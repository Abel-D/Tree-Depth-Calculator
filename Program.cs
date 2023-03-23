// See https://aka.ms/new-console-template for more information
using Tree_Of_Branches;

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

var depth = TreeDepthCalculator.CalculateTreeDepth(root);

Console.WriteLine(depth);