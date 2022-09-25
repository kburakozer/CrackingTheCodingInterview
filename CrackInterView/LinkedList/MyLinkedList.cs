using System.Collections;

namespace CrackInterview.Linkedlist
{
    public class MyLinkedList
    {
        public Node? head =null;
        
        public void AddBack (int n)
        {
            if(head == null)
            {
                head = new Node(n);
            }
            else
            {
                Node current = head;
            
                while(current.next != null)
                {
                    current = current.next;
                }
                current.next = new Node(n);
            }
            
        }

        public void Print(MyLinkedList list)
        {
            if(head != null)
            {
                Node? current = list.head;

                while(current != null)
                {
                    Console.WriteLine(current.Data);
                    current = current.next!;
                }
            }
            
        }
    }
}