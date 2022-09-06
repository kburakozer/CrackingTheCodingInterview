namespace CrackInterview.Linkedlist
{
    public class MyLinkedList
    {
        public Node? head;
        public Node? tail;

        public MyLinkedList()
        {
            head = null;
            tail = null;
        }

        public void AddBack(int n)
        {
            Node current = head;
            Node node = new Node(n);            
            if(current == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                while(current.next != null)
                {
                    current = current.next;
                }
                current.next = node;
                tail =current.next;
            }
        }

        public void Delete(int n)
        {
            Node temp;
            Node current = head;

            if(head.data == n)
            {
                head = head.next;
            }

            else
            {
                while(current.next.data != n)
                {
                    current = current.next;
                }
                temp = current.next;
                current.next = temp.next;
            }
        }

        public void Print()
        {
            Node current = head;
            if(current != null)
            {
                while(current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }
            
        }
    }
}