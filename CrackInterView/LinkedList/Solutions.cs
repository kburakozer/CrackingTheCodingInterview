namespace CrackInterview.Linkedlist
{
    public class Solutions
    {
        public void RemoveDubs(MyLinkedList list)
        {
            Dictionary<int,bool> dict = new Dictionary<int, bool>();
            
            if(list.head == null)
            {
                return;
            }

            Node current = list.head;

            while(current?.next != null)
            {
                if(!dict.ContainsKey(current.next.Data))
                {
                    dict.Add(current.next.Data, true);
                    current = current.next;
                }
                else
                {
                    current.next = current.next.next;
                }
            }
        }
    
        public Node KthToLast(MyLinkedList list, int k)
        {
            int index = 0;
            
            if(list.head == null)
            {
                return null!;
            }

            Node current = list.head;

            while(current != null && index < k)
            {
                index++;
                current = current.next!;
            }

            return current!;
        }
    
        public void DelMidNode (Node n)
        {
            if (n == null || n.next == null)
            {
                return;
            }
            Node next = n.next;
            n.Data = next!.Data;
            n.next = next.next;
        }

        public Node Partition (MyLinkedList list, int x)
        {
            Node? node = list.head;
            Node? head = node;
            Node? tail = node;

            while(node != null)
            {
                Node next = node.next!;
                if(node.Data < x)
                {
                    node.next = head;
                    head = node;
                }
                else
                {
                    tail!.next = node;
                    tail = node;
                }
                node = next;
            }
            tail!.next = null;
            return head!;
        }
    

    }
}