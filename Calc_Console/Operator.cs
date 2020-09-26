using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Console
{
    class Operator
    {
        static Operator instance;
        private Operator()
        {

        }
        public static Operator CreateInstance()
        {

            if (instance == null)
            {
                instance = new Operator();
            }

            return instance;
        }

        public void PlusM(ref float win, ref float lose, out string oper, int alphaNum, int betaNum, out int result)
        {
            oper = "+";
            Console.Write($"{alphaNum} {oper} {betaNum} =\t");
            result = int.Parse(Console.ReadLine().Trim().Replace("", " "));
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
                    Console.WriteLine("다시 입력해 주세요");
                    lose++;
                    break;
                }
            }
        }
        public void MinusM(ref float win, ref float lose, out string oper, int alphaNum, int betaNum, out int result)
        {
            oper = "-";
            Console.Write($"{alphaNum} {oper} {betaNum} =\t");
            result = int.Parse(Console.ReadLine().Trim().Replace("", " "));
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
        public void MultipM(ref float win, ref float lose, out string oper, int alphaNum, int betaNum, out int result)
        {
            oper = "*";
            Console.Write($"{alphaNum} {oper} {betaNum} =\t");
            result = int.Parse(Console.ReadLine().Trim().Replace("", " "));
            if ((alphaNum * betaNum) == result)
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
        public void DivisionM(ref float win, ref float lose, out string oper, int alphaNum, int betaNum, out int result)
        {
            oper = "/";
            Console.Write($"{alphaNum} {oper} {betaNum} =\t");
            result = int.Parse(Console.ReadLine().Trim().Replace("", " "));
            if ((alphaNum / betaNum) == result)
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
