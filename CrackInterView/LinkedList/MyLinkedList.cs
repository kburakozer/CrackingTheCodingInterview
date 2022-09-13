using System.Collections;

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

        public void RemoveDubs()
        {
            HashSet<int> set = new HashSet<int>();
            Node prev = null;
            Node current = head;

            while(current != null)
            {
                if(set.Contains(current.data))
                {
                    prev.next = current.next;
                }
                else
                {
                    set.Add(current.data);
                    prev = current;
                    
                }
                current = current.next;
            }

        }

        public void RemoveDubsNoBuff()
        {
            Node current = head;

            while(current != null)
            {
                Node runner = current;
                
                while(runner.next != null)
                {
                    if(runner.next.data == current.data)
                    {
                        runner.next = runner.next.next;
                    }
                    else
                    {
                        runner = runner.next;
                    }
                }
                current = current.next;
            }
            
        }

        public void KToLast(int k)
        {
            // Node current = head;
            // Node start = head;

            // for(var i = 0; i < k; k++)
            // {
            //     current = current.next;
            //     start = start.next;
            // }

            // while(start != null)
            // {
            //     Console.WriteLine(start.data);
            //     start = start.next;
            // }
        }

        public void Partition(int n)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            Node current = head;
            while(current != null)
            {
                if(current.data >= n)
                {
                    right.Add(current.data);
                    current = current.next;
                }
                else
                {
                    left.Add(current.data);
                    current = current.next;
                }
            }
            head = new Node(left[0]);
            current = head;
            for(int i = 1; i < left.Count; i++)
            {
                Node node = new Node(left[i]);
                current.next = node;
                Node temp = current.next;
                current = temp;
                
            }
            for(int i = 0; i < right.Count; i++)
            {
                Node node = new Node(right[i]);
                current.next = node;
                Node temp = current.next;
                current = temp;
            }
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