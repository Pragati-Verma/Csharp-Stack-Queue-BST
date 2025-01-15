using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Stack
    {
        private int[] elements;
        private int top;
        private int max;
        public Stack(int size)
        {
            elements = new int[size];
            top = -1;
            max = size;
        }
        public void push(int value)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack overflow");
                return;
            }
            elements[++top] = value;
        }
        public int pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack underflow");
                return -1;
            }
            return elements[top--];
        }
        public void isEmpty()
        {
            Console.WriteLine(top == -1 ? "Stack is empty" : "There are elements in stack");
            //return top == -1;
        }
        public void peek()
        {
            Console.WriteLine($"Top element is: {elements[top]}");
        }
        public void display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("*****\nDISPLAYING STACK\n*****");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
    internal class StackDemo
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(4);
            Console.WriteLine("------------------------------------\n" +
                "Choose what to do:\n1. Create stack\n2. Push element" +
                "\n3. Pop element\n4. Peek element\n5. Check if stack is empty\n" +
                "6. Display stack\n7. Press 0 to end\n------------------------------------");
            int value = Convert.ToInt32(Console.ReadLine());
            while (value != 0)
            {
                switch (value)
                {
                    case 1:
                        Console.WriteLine("Enter the size of stack:");
                        int stackLength = Convert.ToInt32(Console.ReadLine());
                        stack = new Stack(stackLength);
                        break;
                    case 2:
                        Console.WriteLine("Enter element to push to stack");
                        int enteredInput = Convert.ToInt32(Console.ReadLine());
                        stack.push(enteredInput);
                        break;
                    case 3:
                        stack.pop();
                        break;
                    case 4:
                        stack.peek();
                        break;
                    case 5:
                        stack.isEmpty();
                        break;
                    case 6:
                        stack.display();
                        break;
                    case 7: break;
                    default:
                        Console.WriteLine("Enter valid number: between 0 and 6");
                        break;
                }
                Console.WriteLine("------------------------------------\n" +
                    "Choose what to do:\n1. Create stack\n2. Push element" +
                "\n3. Pop element\n4. Peek element\n5. Check if stack is empty\n" +
                "6. Display stack\n7. Press 0 to end\n------------------------------------");
                value = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("****PROGRAM ENDED****");
            //Stack st = new Stack(6);
            //st.push(10);
            //st.push(2);
            //st.push(9);
            //st.push(18);
            //st.display();
            //Console.WriteLine($"Removed element: {st.pop()}");
            //st.push(44);
            //st.push(69);
            ////st.push(80);
            //st.display();
            //st.pop();
            //st.pop();
            //st.pop();
            //st.pop();
            //st.pop();
            //st.isEmpty();
            Console.ReadKey();
        }
    }
}

