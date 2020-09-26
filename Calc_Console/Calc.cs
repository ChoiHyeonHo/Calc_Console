using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Console
{
    public class Calc
    {
        public void PlusM(ref float win, ref float lose, out string oper, int alphaNum, int betaNum, out int result)
        {
            oper = "+";
            Console.Write($"{alphaNum} {oper} {betaNum} =\t");
            try
            {
                result = int.Parse(Console.ReadLine());
            }
            catch
            {
                throw;
            }
            while (true)
            {
                if ((alphaNum + betaNum) == result)
                {
                    Console.WriteLine("정답입니다.");
                    win++;
                    break;
                }
                else
                {
                    Console.WriteLine("오답입니다.");
                    lose++;
                    break;
                }
            }
        }
        public void MinusM(ref float win, ref float lose, out string oper, int alphaNum, int betaNum, out int result)
        {
            oper = "-";
            Console.Write($"{alphaNum} {oper} {betaNum} =\t");
            try
            {
                result = int.Parse(Console.ReadLine());
            }
            catch
            {
                throw;
            }
            if ((alphaNum - betaNum) == result)
            {
                Console.WriteLine("정답입니다.");
                win++;
            }
            else
            {
                Console.WriteLine("오답입니다.");
                lose++;
            }
        }
        public void MultipM(ref float win, ref float lose, out string oper, int alphaNum, int betaNum, out int result)
        {
            oper = "*";
            Console.Write($"{alphaNum} {oper} {betaNum} =\t"); 
            try
            {
                result = int.Parse(Console.ReadLine());
            }
            catch
            {
                throw;
            }
            if ((alphaNum * betaNum) == result)
            {
                Console.WriteLine("정답입니다.");
                win++;
            }
            else
            {
                Console.WriteLine("오답입니다.");
                lose++;
            }
        }
        public void DivisionM(ref float win, ref float lose, out string oper, int alphaNum, int betaNum, out int result)
        {
            oper = "/";
            Console.Write($"{alphaNum} {oper} {betaNum} =\t");
            try
            {
                result = int.Parse(Console.ReadLine());
            }
            catch
            {
                throw;
            }
            if ((alphaNum / betaNum) == result)
            {
                Console.WriteLine("정답입니다.");
                win++;
            }
            else
            {
                Console.WriteLine("오답입니다.");
                lose++;
            }
        }
    }
}
