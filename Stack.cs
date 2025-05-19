using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1
{
    public class Node

    {

        public Node next;

        public int data;

        public Node(int Data)
        {

            next = null;

            data = Data;

        }

    }
    public class Stack
    {

        private Node top;
        
        public Stack()
        {

            top = null;

        }

        public Boolean isEmpty()
        {

            if (top == null)

            {

                Console.WriteLine("The stack is empty.");

                return true;

            }

            else

            {

                Console.WriteLine("Stack is not empty.");

                Console.WriteLine();

                return false;

            }

        }

        public void Push(int data)
        {

            Node newNode = new Node(data);

            newNode.next = top;

            top = newNode;

            Console.WriteLine("{0} pushed to stack.", top.data);

            Console.WriteLine();

        }

        public int Pop()
        {

            if (top == null)

            {

                Console.WriteLine("The stack is empty.");

                return -1;

            }

            else

            {

                int popData = top.data;

                top = top.next;

                Console.WriteLine("{0} popped from stack.", popData);

                Console.WriteLine();

                return popData;

            }

        }

        public void Display()
        {

            Node current = top;

            Console.WriteLine("Stack elements:");

            while (current != null)
            {

                Console.WriteLine(current.data);

                current = current.next;

            }

            Console.WriteLine();

        }

        public static void Main()
        {

            Stack stack1 = new Stack();

            int choice;

            int number;


            Console.WriteLine("Stack operations:");

            Console.WriteLine("1. Push");

            Console.WriteLine("2. Pop");

            Console.WriteLine("3. Check if Empty");

            Console.WriteLine("4. Display Stack");

            Console.WriteLine("5. Exit");

            do
            {

                Console.Write("Enter your choice: ");


                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1:

                        Console.Write("Enter the value to push: ");

                        number = Convert.ToInt32(Console.ReadLine());

                        stack1.Push(number);

                        break;

                    case 2:

                        stack1.Pop();

                        break;

                    case 3:

                        stack1.isEmpty();

                        break;

                    case 4:

                        stack1.Display();

                        break;

                    case 5:

                        Console.WriteLine("Exiting program.");

                        break;

                    default:

                        Console.WriteLine("Invalid choice!");

                        break;

                }

            } while (choice != 5);

        }

    }
}