using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Console
{
    public class Calc
    {
        public void PlusM(ref float win, ref float lose, out string oper, int alphaNum, int betaNum)
        {
            oper = "+";
            int result;
            int cnt = 1;
            bool cFlag = true;
            bool dFlag = true;
            Console.Write($"{alphaNum} {oper} {betaNum} =\t");

            try
            {
                while (cFlag == true)
                {
                    result = int.Parse(Console.ReadLine());
                    if ((alphaNum + betaNum) == result && cFlag == true && dFlag == true)
                    {
                        Console.WriteLine("정답입니다.");
                        win++;
                        break;
                    }
                    else if ((alphaNum + betaNum) == result && cFlag == true && dFlag == false)
                    {
                        Console.Write($"{cnt}회 시도.");
                        Console.WriteLine("정답입니다.");
                        lose++;
                        break;
                    }
                    else if ((alphaNum + betaNum) != result)
                    {
                        Console.WriteLine("오답입니다. 다시 입력해 주세요.");
                        cFlag = true;
                        dFlag = false;
                        cnt++;
                        continue;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("숫자, 또는 연산자+숫자로 입력해 주세요");
                Console.WriteLine("예시) 1 , 0 또는 -1");
            }
        }
        public void MinusM(ref float win, ref float lose, out string oper, int alphaNum, int betaNum)
        {
            oper = "-";
            int result;
            int cnt = 1;
            bool cFlag = true;
            bool dFlag = true;
            Console.Write($"{alphaNum} {oper} {betaNum} =\t");
            try
            {
                while (cFlag == true)
                {
                    result = int.Parse(Console.ReadLine());
                    if ((alphaNum - betaNum) == result && cFlag == true && dFlag == true)
                    {
                        Console.WriteLine("정답입니다.");
                        win++;
                        break;
                    }
                    else if ((alphaNum - betaNum) == result && cFlag == true && dFlag == false)
                    {
                        Console.Write($"{cnt}회 시도.");
                        Console.WriteLine("정답입니다.");
                        lose++;
                        break;
                    }
                    else if ((alphaNum - betaNum) != result)
                    {
                        Console.WriteLine("오답입니다. 다시 입력해 주세요.");
                        cFlag = true;
                        dFlag = false;
                        cnt++;
                        continue;
                    }
                }
            }
            catch(Exception)
            {
                Console.WriteLine("숫자, 또는 연산자+숫자로 입력해 주세요");
                Console.WriteLine("예시) 1 , 0 또는 -1");
            }
        }
        public void MultipM(ref float win, ref float lose, out string oper, int alphaNum, int betaNum)
        {
            oper = "*";
            int result;
            int cnt = 1;
            bool cFlag = true;
            bool dFlag = true;
            Console.Write($"{alphaNum} {oper} {betaNum} =\t");
            try
            {
                while (cFlag == true)
                {
                    result = int.Parse(Console.ReadLine());
                    if ((alphaNum * betaNum) == result && cFlag == true && dFlag == true)
                    {
                        Console.WriteLine("정답입니다.");
                        win++;
                        break;
                    }
                    else if ((alphaNum * betaNum) == result && cFlag == true && dFlag == false)
                    {
                        Console.Write($"{cnt}회 시도.");
                        Console.WriteLine("정답입니다.");
                        lose++;
                        break;
                    }
                    else if((alphaNum * betaNum) != result)
                    {
                        Console.WriteLine("오답입니다. 다시 입력해 주세요.");
                        cFlag = true;
                        dFlag = false;
                        cnt++;
                        continue;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("숫자, 또는 연산자+숫자로 입력해 주세요");
                Console.WriteLine("예시) 1 , 0 또는 -1");
            }
        }
        public void DivisionM(ref float win, ref float lose, out string oper, int alphaNum, int betaNum)
        {
            oper = "/";
            int result;
            int cnt = 1;
            bool cFlag = true;
            bool dFlag = true;
            Console.Write($"{alphaNum} {oper} {betaNum} =\t");
            try
            {
                while (cFlag == true)
                {
                    result = int.Parse(Console.ReadLine());
                    if ((alphaNum / betaNum) == result && cFlag == true && dFlag == true)
                    {
                        Console.WriteLine("정답입니다.");
                        win++;
                        break;
                    }
                    else if ((alphaNum / betaNum) == result && cFlag == true && dFlag == false)
                    {
                        Console.Write($"{cnt}회 시도.");
                        Console.WriteLine("정답입니다.");
                        lose++;
                        break;
                    }
                    else if ((alphaNum / betaNum) != result)
                    {
                        Console.WriteLine("오답입니다. 다시 입력해 주세요.");
                        cFlag = true;
                        dFlag = false;
                        cnt++;
                        continue;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("숫자, 또는 연산자+숫자로 입력해 주세요");
                Console.WriteLine("예시) 1 , 0 또는 -1");
            }
        }
    }
}


