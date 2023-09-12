using System.Runtime.CompilerServices;

namespace CSStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            string strEmpty = string.Empty;
            string strNull = null;

            if(string.IsNullOrEmpty(strEmpty))
            {
                Console.WriteLine("strEmpty is an empty string");
            }
            if(string.IsNullOrEmpty(strNull))
            {
                Console.WriteLine("strNull is a null string");
            }
        }
    }
}