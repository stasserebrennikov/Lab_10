using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Corner corner;
            do
            {
                Console.WriteLine("Введите данные");
                int gradus_ = Convert.ToInt32(Console.ReadLine());
                int minute_ = Convert.ToInt32(Console.ReadLine());
                int sec_ = Convert.ToInt32(Console.ReadLine());
                corner = new Corner(gradus_, minute_, sec_);
            }
            while (corner.isCorrect == false);
            double totalCorner = corner.ToRadians();
            Console.WriteLine(totalCorner);
            Console.ReadKey();
        }
    }
}
