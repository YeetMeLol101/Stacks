namespace Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack Name = new Stack();

            Name.Push("One");//Fix these later
            Name.Push("Two");
            Name.Push("Three");
            Name.Push("Four");

            Name.Push("Five"); //Stack Overflow at this point
            Name.Push("Six");
            Name.Push("Seven");
            Name.Push("Eight");
            Name.Push("Nine");
            Name.Push("Ten");

            Name.PrintStack();

            Console.WriteLine(Name.Pop());
            Console.WriteLine(Name.Pop());
            Console.WriteLine(Name.Pop());
            Console.WriteLine(Name.Pop());
            Console.WriteLine(Name.Pop()); //Stack Underflow

            Console.WriteLine(Name.Peek());

            

        }
    }

    class Stack
    {
        private const int MaxSize = 4;
        private string[] STACK = new string[MaxSize];
        private int TOP = -1;
        public bool IsFull()
        {
            return (TOP == MaxSize - 1);

            /*Does the same as:
            if (TOP == MaxSize - 1)
                return true;
            else
                return false;
            */

        }

        public bool IsEmpty()
        {
            return (TOP == -1);

            /*Does the same as:
            if (TOP == -1)
                return true;
            else
                return false;*/

        }

        public void Push(string DATA)
        {
            if (IsFull() /*== true*/)
            {
                Console.WriteLine($"Stack is full -- {DATA} could not be loaded");
            }
            else
            {
                TOP = TOP + 1;
                STACK[TOP] = DATA;
            }
        }

        public string Pop()
        {
            string PoppedItem;

            if (IsEmpty() /*== true*/)
            {
                Console.WriteLine($"Stack is empty -- nothing to pop");
                PoppedItem = "";
            }
            else
            {
                PoppedItem = STACK[TOP];
                TOP = TOP - 1;
            }
            return PoppedItem;
        }

        public string Peek()
        {
            string PeekedItem;

            if (IsEmpty())
            {
                Console.WriteLine($"Stack is empty -- nothing to peek");
                PeekedItem = "";
            }
            else
            {
                PeekedItem = STACK[TOP];
            }
            return PeekedItem;
        }

        public void PrintStack()
        {
            foreach (string value in STACK) //Does the same as: [for (int i; i < TOP; i++)] with PrintStack referencing TOP
            {
                Console.WriteLine(value);
            }
        }
    }
}
