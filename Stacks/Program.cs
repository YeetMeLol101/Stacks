namespace Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push("One");//Fix these later
            stack.Push("Two");
            stack.Push("Three");
            Push(stack, ref top, "Four");

            Push(stack, ref top, "Five"); //Stack Overflow at this point
            Push(stack, ref top, "Six");
            Push(stack, ref top, "Seven");
            Push(stack, ref top, "Eight");
            Push(stack, ref top, "Nine");
            Push(stack, ref top, "Ten");

            PrintStack(ref stack);

            Console.WriteLine(Pop(stack, ref top));
            Console.WriteLine(Pop(stack, ref top));
            Console.WriteLine(Pop(stack, ref top));
            Console.WriteLine(Pop(stack, ref top));
            Console.WriteLine(Pop(stack, ref top)); //Stack Underflow

            Console.WriteLine(Peek(stack, ref top));
            Console.WriteLine(Peek(stack, ref top));
            Console.WriteLine(Peek(stack, ref top));
            Console.WriteLine(Peek(stack, ref top));
            Console.WriteLine(Peek(stack, ref top));

            

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
