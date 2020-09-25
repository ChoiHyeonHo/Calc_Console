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
            Console.WriteLine("난이도: 1. 상 \t 2. 중 \t 3. 하 \t 4. 종료");
            Console.WriteLine("=========================================");

            int choice = int.Parse(Console.ReadLine());
            Operator oper = new Operator();

            switch (choice)
            {
                case 1: oper.calcul(); break;
                case 2: break;
                case 3: break;
                case 4: Console.WriteLine("프로그램을 종료합니다."); return;
            }
        }
    }
}
