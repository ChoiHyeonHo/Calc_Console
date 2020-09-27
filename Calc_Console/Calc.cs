using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Console
{
    public class Calc
    {
        public void PlusM(ref float win, ref float lose, out string oper, int alphaNum, int betaNum) // 덧셈 메서드
        {
            oper = "+"; // 난수 1일경우 연산기호 + 설정
            int result;
            int cnt = 1; // 시도 수 카운트
            bool cFlag = true;
            bool dFlag = true; //1회 시도후 오답일 경우 false 전환하여 else if문으로 갈 수 있도록
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
        public void MinusM(ref float win, ref float lose, out string oper, int alphaNum, int betaNum) // 뺄셈 메서드
        {
            oper = "-"; //난수 2일 경우 연산기호 -
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
        public void MultipM(ref float win, ref float lose, out string oper, int alphaNum, int betaNum) //곱셈 메서드
        {
            oper = "*"; //난수 1~4중 1,2,3을 제외한 나머지 경우 연산기호 *
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
        public void DivisionM(ref float win, ref float lose, out string oper, int alphaNum, int betaNum) //나눗셈 메서드
        {
            oper = "/"; //난수 3일 경우 연산기호 /
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


