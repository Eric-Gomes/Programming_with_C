using System;
using System.Collections.Generic;
using System.Text;

namespace StackCalculator
{
    class IntStack
    {

  
            public const int maxsize = 10; //Capacity of stack
            public int top = 0; //Stack beings at 0
            private int[] array = new int[maxsize]; //Build an array up


            public void Push(int value)
            {
                array[top++] = value; // insert code here 
            }

            public int Pop()
            {

                return array[--top];
             
            }

            public int Peek()
            {
                return array[top - 1];
            }


            public bool IsEmpty()
            {
                return top == 0;// insert code here
            }

            public bool IsFull()
            {
                return top == maxsize;
            }

         public string Print()
        {
            StringBuilder output = new StringBuilder();
            for (int i = top - 1; i >= 0; i--)
                output.Append(array[i] + Environment.NewLine);
            return output.ToString();
        }

    }

}
