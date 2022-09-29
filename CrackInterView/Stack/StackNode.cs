

namespace CrackInterview.Stack
{
    public class StackNode<T>
    {
        public T Data;
        public StackNode<T>? next;

        public StackNode(T data)
        {
            Data = data;
        }
    }
}