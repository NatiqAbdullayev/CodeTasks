namespace ConsoleApp8;

internal class Program
{
    private int[] Test { get; set; } = [];
    static void Main(string[] args)
    {
        CustomList<int> list = new CustomList<int>();
        list.Add(2);
        list.Add(3);
        list.Add(4);


        Console.WriteLine(list.Count());

        foreach (int item in list)
        {
            Console.WriteLine(item);
        }
    }
}
