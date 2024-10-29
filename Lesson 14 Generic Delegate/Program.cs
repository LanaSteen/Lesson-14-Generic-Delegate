using Algorithms;

namespace Lesson_14_Generic_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] stringVehicles = File.ReadAllLines("C:\\Users\\User\\Desktop\\IT STEP\\BCTSO-20-NC-2\\BCTSO-20-NC-2\\Lecture11\\vehicles.csv");
            //var res = CustomAlgorithm.Select(stringVehicles, Vehicle.Parse);

            string[] numbersAsText = { "10", "20", "2", "3" };
            var res2 = CustomAlgorithm.Select(numbersAsText, int.Parse);
            //Console.WriteLine(res2[0]);

            var res = CustomAlgorithm.IndexOf(numbersAsText, num => num == "20");
            Console.WriteLine(res);
        }
    }
}
