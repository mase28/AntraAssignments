using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWithGenerics
{
    public class MyStack<T>
    {
        private Stack<T> stack;

        public MyStack()
        {
            stack = new Stack<T>();
        }

        public int Count()
        {
            return stack.Count;
        }

        public T Pop()
        {
            return (T)stack.Pop();
        }

        public void Push(T value)
        {
            stack.Push(value);
        }
    }
}
