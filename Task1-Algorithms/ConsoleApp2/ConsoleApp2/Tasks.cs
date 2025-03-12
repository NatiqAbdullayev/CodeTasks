namespace ConsoleApp2;

public class Tasks
{
    public static void compareGivenInt(int[] arr, int givenInt)
    {
        foreach (int item in arr)
        {
            if (givenInt > item)
            {
                Console.WriteLine(true);
            }
            else if (givenInt == item)
            {
                Console.WriteLine("equals");
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }


    public static void findBigger(int[] arr)
    {
        int newInt = 0;

        foreach (var i in arr)
        {
            if (i > newInt)
            {
                newInt = i;
            }
        }

        Console.WriteLine(newInt);
    }

    public static void checkPolindrom(int[] arr)
    {
        foreach (var i in arr)
        {
            if (i / 100 != 0)
            {
                int first = (i / 10) / 10;
                int third = i % 10;
                if (first == third)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }


    public static void calculateFactorial(int givenNumber)
    {
        int factorial = 1;
        for (int i = givenNumber; i > 0; i--)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);
    }


    public static void sadeMurekkeb(int givenInt)
    {
        int count = 0;

        for (int i = 1; i <= givenInt; i++)
        {
            if (givenInt % i == 0)
            {
                count++;
            }
        }


        Console.WriteLine(count);
        if (count > 2)
        {
            Console.WriteLine("murekkeb");
        }
        else
        {
            Console.WriteLine("sade");
        }
    }

    public static void checkLetter(string givenLetter, string givenNumber)
    {
        string givenWord = "test";

        if (givenWord.Contains(givenWord))
        {
            Console.WriteLine(true);
        }
    }

    public static void findWord(string[] stringArr, string givenWord)
    {
        foreach (string s in stringArr)
        {
            if (s.Equals(givenWord))
            {
                Console.WriteLine(s);
            }
        }
    }

    public static void reverseArray(string[] stringArr)
    {
        for (int i = stringArr.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(stringArr[i]);
        }
    }

    public static void reverseArraysItems(string[] stringArr)
    {
        foreach (string s in stringArr)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }

            Console.WriteLine(" ");
        }
    }

    public static int resultOfNumber(int number)
    {
        int a = (number / 10) % 10;
        int b = number % 10;
        int c = number / 100;

        return a + b + c;
    }
}