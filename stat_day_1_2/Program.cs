using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stat_day_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] intInput = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            double mean = intInput.Average();

            List<double> sqDist = new List<double>();

            for (int i = 0; i < intInput.Length; i++)
            {
                sqDist.Add(Math.Pow(Convert.ToDouble((intInput[i] - mean)), 2.0));
            }
            foreach (double d in sqDist)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine(string.Format("{0:F1}", Math.Sqrt(sqDist.Sum() / n)));
            Console.ReadLine();
        }
    }
}
