using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Console
{
    class Operator //사칙연산 메서드
    {
        public void calcul()
        {
            for (int i = 0; i <= 5; i++)
            {
                Random rNum = new Random();
                Random oNum = new Random();

                string oper;
                int symbol = oNum.Next(1, 5);
                int alphaNum = rNum.Next(1, 100);
                int betaNum = rNum.Next(1, 100);
                int result;
                int win = 0, lose= 0;

                if (symbol == 1)
                {
                    oper = "+";
                    Console.Write($"{alphaNum} {oper} {betaNum} =");
                    result = int.Parse(Console.ReadLine());
                    while (true)
                    {
                        if ((alphaNum + betaNum) == result)
                        {
                            Console.WriteLine("정답입니다.");
                            win++;
                            break; //반복문탈출
                        }
                        else
                        {
                            Console.WriteLine("오답입니다.");
                            Console.WriteLine("다시 입력해 주세요");
                            continue; //아래를 건너뛰고 조건문 다시 수행
                        }
                    }
                }
                else if (symbol == 2)
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
                    }
                }
                else if (symbol == 3)
                {
                    oper = "*";
                    Console.Write($"{alphaNum} {oper} {betaNum} =");
                    result = int.Parse(Console.ReadLine());
                    if ((alphaNum * betaNum) == result)
                    {
                        Console.WriteLine("정답입니다.");
                        win++;
                    }
                    else
                    {
                        Console.WriteLine("오답입니다.");
                        Console.WriteLine("다시 입력해 주세요");
                    }
                }
                else
                {
                    oper = "/";
                    Console.Write($"{alphaNum} {oper} {betaNum} =");
                    result = int.Parse(Console.ReadLine());
                    if ((alphaNum / betaNum) == result)
                    {
                        Console.WriteLine("정답입니다.");
                        win++;
                    }
                    else
                    {
                        Console.WriteLine("오답입니다.");
                        Console.WriteLine("다시 입력해 주세요");
                    }
                }
                Console.WriteLine("================================");
                Console.WriteLine($"total: {win+lose}\t win: {win}\t lose: {lose}");
            }
        }
    }
}
