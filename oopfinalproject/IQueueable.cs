using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfinalproject
{
    public interface IQueueable<T>
    {
        public void Enqueue(T item);

        public T Dequeue();

        public T Peek();

        public bool isEmpty();
    }
}
