using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace oopfinalproject
{
    public class CustomQueue<T>
    {
        private T[] myArray;
        private int tail;
        private int count;

        public CustomQueue(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("the capacity must be greater than zero");
            }
            myArray = new T[capacity];
            tail = 0;
            count = 0;
        }

        public void Enqueue(T item)
        {
            if (count == myArray.Length)
            {
                Console.WriteLine("the queue is full cannot enqueue");
                return;
            }
            myArray[tail] = item;
            count++;
        }
        public T Dequeue()
        {
            if (count == 0)
            {
                throw new Exception("the queue is empty cannot dequeue");
            }

            T item = myArray[0];

            for (int i = 0; i < count; i++)
            {
                myArray[i - 1] = myArray[i];
            }
            myArray[count - 1] = default(T); 

            return item;
        }
        public T Peek()
        {
            if (count == 0)
            {
                throw new Exception("the queue is empty cannot dequeue");
            }
            return myArray[0];
        }
        public bool isEmpty()
        {
            if(count == 0)
            {
                Console.WriteLine("the array is empty");
                return count == 0;
            }
            else
            {
                Console.WriteLine("the array is not empty");
                
            }
            Console.WriteLine("emptying the array");
                return count == 0;
        }
    }
}
