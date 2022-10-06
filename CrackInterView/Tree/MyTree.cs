

namespace CrackInterview.Tree
{
    public class MyTree
    {
        public TreeNode? root;

        public MyTree()
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
                    if(val < currentNode.Data)
                    {
                        if(currentNode.left == null)
                        {
                            currentNode.left = new TreeNode(val);
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.left; 
                        }
                           
                    }
                    else if(val >= currentNode.Data)
                    {
                        if(currentNode.right == null)
                        {
                            currentNode.right = new TreeNode(val);
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.right;
                        }
                    }
                }
                currentNode = new TreeNode(val);
                
            }
        }

        public void InOrderTraversal(TreeNode node)
        {
            if(node.left != null)
            {
                InOrderTraversal(node.left);
            }
            Console.WriteLine(node.Data);

            if(node.right != null)
            {
                InOrderTraversal(node.right);
            }
        }

        public void PreOrderTraversal(TreeNode node)
        {
            Console.WriteLine(node.Data);
            if(node.left != null)
            {
                PreOrderTraversal(node.left);
            }
            if(node.right != null)
            {
                PreOrderTraversal(node.right);
            }
        }

        public void PostOrderTraversal(TreeNode node)
        {
            if(node.left != null)
            {
                PreOrderTraversal(node.left);
            }
            if(node.right != null)
            {
                PreOrderTraversal(node.right);
            }
            Console.WriteLine(node.Data);
        }

        public void BFS()
        {
            Queue<TreeNode> q =  new Queue<TreeNode>();
            if(root == null)
            {
                return;
            }
            var currentNode = root;
            q.Enqueue(currentNode);

            while(q.Count > 0 )
            {
                currentNode = q.Dequeue();
                
                if(currentNode.left != null)
                {
                    q.Enqueue(currentNode.left);
                }
                if(currentNode.right != null)
                {
                    q.Enqueue(currentNode.right);
                }
                Console.WriteLine(currentNode.Data);
            }

        }
    
        public void DFS()
        {
            if(root == null)
            {
                return;
            }
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);
            
            while(s.Count > 0)
            {
                TreeNode currentNode = s.Pop();
                Console.WriteLine(currentNode.Data);
                if(currentNode.right != null)
                {
                    s.Push(currentNode.right);
                }
                if(currentNode.left != null)
                {
                    s.Push(currentNode.left);
                }
                
            }
        }
    }   
}
