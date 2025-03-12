namespace ConsoleApp3;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, -5, -6, 7, 8, 9, 10 };
        Console.WriteLine(ArrayToString(numbers));
    }


    public static string ArrayToString(int[] array)
    {
        string output = "";
        foreach (int i in array)
        {
            output += i.ToString();
            output += " ";
        }

        return output;
    }

    public static int SumOfArrayItems(int[] array)
    {
        int total = 0;
        foreach (int i in array)
        {
            total += i;
        }

        return total;
    }

    public static void checkMenfi(int[] array)
    {
        foreach (int i in array)
        {
            if (i < 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    
    //Method overloading 
    public static int CalculatePerimeter(int a, int b, int c)
    {
        return a + b + c;
    }

    public static int CalculatePerimeter(int a, int b, int c, int d)
    {
        return (a + b) * 2;
    }

    public static int CalculateArea(int a, int b)
    {
        return a * b;
    }

    public static int CalculateArea(int a)
    {
        return a * a;
    }
}