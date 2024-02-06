namespace Stacks
{
    internal class Program
    {
        const int MaxSize = 4;
        
        static bool IsFull(int TOP)
        {
            return (TOP == MaxSize - 1);

            /*Does the same as:
            if (TOP == MaxSize - 1)
                return true;
            else
                return false;
            */
            
        }

        static bool IsEmpty(int TOP)
        {
            return (TOP == -1);

            /*Does the same as:
            if (TOP == -1)
                return true;
            else
                return false;*/

        }

        static void Push(string[] STACK, ref int TOP, string DATA)
        {
            if (IsFull(TOP) /*== true*/)
            {
                Console.WriteLine($"Stack is full -- {DATA} could not be loaded");
            }
            else
            {
                TOP = TOP + 1;
                STACK[TOP] = DATA;
            }
        }

        static string Pop(string[] STACK, ref int TOP)
        {
            string PoppedItem;

            if (IsEmpty(TOP) /*== true*/)
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

        static string Peek(string[] STACK, ref int TOP)
        {
            string PeekedItem;

            if (IsEmpty(TOP) )
            {
                Console.WriteLine($"Stack is empty -- nothing to peek");
                PeekedItem = "";
            }
            else
            {
                PeekedItem = STACK[TOP];
                TOP = TOP - 1;
            }
            return PeekedItem;
        }

        static void PrintStack(ref string[] STACK)
        {
            foreach (string value in STACK) //Does the same as: [for (int i; i < TOP; i++)] with PrintStack referencing TOP
            {
                Console.WriteLine(value);
            }
        }
        static void Main(string[] args)
        {
            string[] stack = new string[MaxSize];
            int top = -1;

            Push(stack, ref top, "One");
            Push(stack, ref top, "Two");
            Push(stack, ref top, "Three");
            Push(stack, ref top, "Four");

            Push(stack, ref top, "Five"); //Stack Overflow at this point
            Push(stack, ref top, "Six");
            Push(stack, ref top, "Seven");
            Push(stack, ref top, "Eight");
            Push(stack, ref top, "Nine");
            Push(stack, ref top, "Ten");

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

            PrintStack(ref stack);

        }
    }
}