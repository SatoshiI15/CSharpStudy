namespace CSStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 3, 4, 5, }, { 6, 7, 8, } };

            int lengthAll = arr.Length;
            int length1 = arr.GetLength(0);
            int length2 = arr.GetLength(1);

            Console.WriteLine(lengthAll);
            Console.WriteLine(length1);
            Console.WriteLine(length2);
        }
    }
}