

namespace CrackInterview.Stack
{
    public class MyStack<T>
    {
        private StackNode<T>? top;

        public T Pop()
        {
            if(top == null)
            {
                throw new ArgumentNullException();
            }

            var item = top.Data;
            top = top.next;
            
            return item;
        }

        public void Push(T item)
        {
            var newStackNode = new StackNode<T>(item);

            newStackNode.next = top;
            top = newStackNode;
        }

        public T Peek()
        {
            if(top == null)
            {
                throw new ArgumentNullException();
            }

            return top.Data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }
}