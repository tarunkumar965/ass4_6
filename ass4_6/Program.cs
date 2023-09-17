using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass4_6
{
    public class SimpleStack<T>
    {
        private T[] items;
        private int top;

        public SimpleStack(int capacity)
        {
            items = new T[capacity];
            top = -1;
        }

        public void Push(T item)
        {
            if (top == items.Length - 1)
            {
                throw new StackOverflowException("Stack is full.");
            }

            items[++top] = item;
        }

        public T Pop()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return items[top--];
        }

        
        public T this[int index]
        {
            get
            {
                if (index < 0 || index > top)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                return items[index];
            }
        }

        public int Count
        {
            get { return top + 1; }
        }

        public bool IsEmpty
        {
            get { return top == -1; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleStack<int> stack = new SimpleStack<int>(5);

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine($"Element at index 1: {stack[1]}");

            while (!stack.IsEmpty)
            {
                Console.WriteLine($"Popped: {stack.Pop()}");

            }
        }
        }
    }

