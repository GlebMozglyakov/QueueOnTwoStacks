using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueOnTwoStacks
{
    public class QueueTwoStacks<T>
    {
        private Stack<T> StackForPush { get; set; }

        private Stack<T> ReverseStack { get; set; }

        public QueueTwoStacks()
        {
            StackForPush = new Stack<T>();
            ReverseStack = new Stack<T>();
        }

        public void Push(T QueueItem)
        {
            StackForPush.Push(QueueItem);
        }

        public T Pop()
        {
            if (ReverseStack.Count == 0)
            {
                while (StackForPush.Count > 0)
                    ReverseStack.Push(StackForPush.Pop());
            }
            if (ReverseStack.Count > 0)
                return ReverseStack.Pop();
            else
                throw new NullReferenceException("Очередь пуста !");
        }
    }
}
