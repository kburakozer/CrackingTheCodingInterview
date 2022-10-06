using CrackInterview.Linkedlist;
using CrackInterview.Tree;


MyTree tree = new MyTree();

tree.Add(14);
tree.Add(5);
tree.Add(7);
tree.Add(24);
tree.Add(20);
tree.Add(26);
tree.Add(3);

tree.PostOrderTraversal(tree.root);