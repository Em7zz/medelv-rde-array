using System;

namespace Arrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temp = { 4.5, 3.2, 6.7, 6.1, 2.1, 1.6, 2.9 };
            Console.WriteLine("Medelvärde: " + Medel(temp));
        }
        public static double Medel(double[] a)
        {
            double summa = 0;
			foreach (double v1 in a)
				summa += v1;
            return (summa / a.Length);
        }
    }
}
