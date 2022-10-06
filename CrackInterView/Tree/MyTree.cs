

namespace CrackInterview.Tree
{
    public class Tree
    {
        public TreeNode? root;

        public Tree()
        {
            root = null;
        }

        public void Add(int val)
        {
            if(root == null)
            {
                root = new TreeNode(val);
            }
            else
            {
                var currentNode = root;
                while(currentNode != null)
                {
                    if(val < root.Data)
                    {
                        currentNode = currentNode.left;    
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
                currentNode = new TreeNode(val);
                
            }
        }
    }   
}
