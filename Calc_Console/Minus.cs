using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Console
{
    class Minus
    {
        public void MinusM(ref float win, ref float lose, out string oper, int alphaNum, int betaNum, out int result)
        {
            oper = "-";
            Console.Write($"{alphaNum} {oper} {betaNum} =");
            result = int.Parse(Console.ReadLine());
            if ((alphaNum - betaNum) == result)
            {
                Console.WriteLine("정답입니다.");
                win++;
            }
            else
            {
                Console.WriteLine("오답입니다.");
                Console.WriteLine("다시 입력해 주세요");
                lose++;
            }
        }
    }
}
