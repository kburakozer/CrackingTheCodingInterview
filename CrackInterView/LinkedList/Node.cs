namespace CrackInterview.Linkedlist
{
    public class Node
    {
        public int Data {get; set;}
        public Node? next {get; set;}
        
        public Node (int d)
        {
            Data = d;
            next = null;
        }

        public Node ()
        {

        }
    }
}