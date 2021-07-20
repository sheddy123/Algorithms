using System;

namespace StackImplementation
{
    public class Stack
    {
        private int _maxSize;
        private int[] arraySize;
        private int top;
        public Stack(int size)
        {
            _maxSize = size;
            arraySize = new int[_maxSize];
            top = -1;
        }
        public bool IsEmpty()
        {
            return arraySize.Length < 0;
        }

        public bool IsFull()
        {
            return (top == arraySize.Length - 1);
        }

        public int Pop()
        {
            return arraySize[top--]; //Access item, decrement top
        }

        public void Push(int item)
        {
            arraySize[++top] = item; //Increment top, then add item
        }
    }
}
