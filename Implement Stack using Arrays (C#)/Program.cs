public class Stack
{
    private int[] elements;
    private int top;
    private int max;

    // Constructor to initialize stack
    public Stack(int size)
    {
        elements = new int[size];
        top = -1;
        max = size;
    }

    // Method to add an element to the stack
    public void Push(int item)
    {
        if (top == max - 1)
        {
            Console.WriteLine("***Stack Overflow***");
            return;
        }
        else
        {
            elements[++top] = item;
            Console.WriteLine($"\nPushed {item} into the stack.\n");
        }
    }

    // Method to remove and return the top element from the stack
    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("***Stack Underflow***");
            return -1;
        }
        else
        {
            Console.WriteLine($"Popped {elements[top]} from the stack.\n");
            return elements[top--];
        }
    }

    // Method to peek at the top element of the stack without removing it
    public int Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("***Stack is empty***\n");
            return -1;
        }
        else
        {
            return elements[top];
        }
    }

    // Method to check if the stack is empty
    public bool IsEmpty()
    {
        return top == -1;
    }

    // Method to print the stack
    public void PrintStack()
    {
        if (top == -1)
        {
            Console.WriteLine("***Stack is empty***\n");
            return;
        }
        else
        {
            Console.Write("> > > Stack elements are: ");
            for (int i = top; i >= 0; i--)
            {
                Console.Write(elements[i]);
                if (i > 0)
                {
                }
                  Console.Write(", ");
              }
            Console.WriteLine(); // Move to the next line after printing all elements
        }
    }

    // Main method to test the stack implementation
    public static void Main()
    {
        Stack stack = new Stack(5);

        stack.Push(5);
        stack.Push(10);
        stack.Push(15);
        stack.Push(20);

        Console.WriteLine($"> > > Top element is: {stack.Peek()}\n");

        stack.Pop();
        stack.Pop();

        stack.PrintStack();

        Console.WriteLine($"\n> > > Is stack empty?! {stack.IsEmpty()}\n");

    }
}