using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Of_circle
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            double A;
            Console.WriteLine("Enter the radius:");
            r = Convert.ToInt32(Console.ReadLine());
            A = (3.142) * r * r;
            Console.WriteLine("The Area of circle of Given radius is=" + A);
            Console.ReadLine();

        }
    }
}
