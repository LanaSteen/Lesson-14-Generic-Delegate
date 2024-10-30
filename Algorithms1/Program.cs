using Algorithms;

namespace Algorithms1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 10, 11 };
            var result = CustomAlgorithm.Sum(arr, el => el>5);
            Console.WriteLine(result);
        }
    }
}
