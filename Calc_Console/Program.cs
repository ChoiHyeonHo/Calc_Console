using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============계산기====================");
            Console.WriteLine("난이도: 1. 상 \t 2. 중 \t 3. 하");
            Console.WriteLine("=========================================");

            while (true)
            {
                Random rNum = new Random();
                rNum.Next(10, 101);
                Random rOper = new Random();
                rOper.Next(1, 5); // 1= '+' , 2= '-', 3= '*', 4= '/'

                Console.Write($"{rNum} {rOper} {rNum} =");
                int result = int.Parse(Console.ReadLine());


            }
        }
    }
}
