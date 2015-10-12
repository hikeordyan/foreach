
namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
             foreach (int element in fibarray)
             {
                System.Console.WriteLine(element);
             }

        }
    }
}
