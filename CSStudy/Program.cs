class Program
{
    static void Main()
    {
        Console.WriteLine("Please input a number; not a character");
        var str = Console.ReadLine();
        try
        {
            var n = int.Parse(str);
            Console.WriteLine(n);
        }
        catch {
            Console.WriteLine(str);
        }
    }
}