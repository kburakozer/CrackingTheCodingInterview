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
    
        public Node SumList(Node l1, Node l2)
        {
            Node dummyHead = new Node();
            Node l3 = dummyHead;

            int carry = 0;
            while(l1 != null || l2 != null)
            {
                var val_1 = (l1 != null) ? l1.Data : 0;
                var val_2 = (l2 != null) ? l2.Data : 0;

                var sum = val_1 + val_2 + carry;

                carry = sum / 10;
                var lastDigit = sum % 10;

                Node newNode = new Node(lastDigit);

                l3.next = newNode;
                l3 = l3.next;

                if (l1 != null)
                    l1 = l1.next!;
                if (l2 != null)
                    l2 = l2.next!;
            }
            return l3;
        }
    }
}