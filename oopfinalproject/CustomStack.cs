using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfinalproject
{
    public class CustomStack<T>
    {
        private T[] array;
        private int top;
        private int capacity;

        public CustomStack(int size)
        {
            capacity = size;
            array = new T[capacity];
            top = -1;
        }
        public void Push(T item)
        {
            if (top == capacity - 1)
            {
                Console.WriteLine("the stack is full");
                return;
            }
            top++;
            array[top] = item;

        }
        public T Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("stack is empty");
                return default(T);
            }
            T value = array[top];
            top--;
            return value;
        }
        public T Peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("stack is empty");
                return default(T);
            }
            return array[top];
        }
        public bool isEmpty()
        {
            return top == -1;
        }
    }
}
