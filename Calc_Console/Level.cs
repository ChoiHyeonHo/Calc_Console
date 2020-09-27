using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Console
{
    class Level
    {
        public void ShowMenu()
        {
            Console.WriteLine("===============계산기====================");
            Console.WriteLine("난이도: 1. 상 \t 2. 중 \t 3. 하 \t 4. 종료");
            Console.WriteLine("=========================================");
        }

        public void HighLevel() //난이도 상 메서드
        {
            Logic logic = new Logic();
            while (true)
            {
                float win, lose;
                WinningRate(logic, out win, out lose); //승률 메서드 호출
                try
                {
                    if ((win / (win + lose) * 100) >= 80)
                    {
                        Console.WriteLine("난이도를 다시 설정하시겠습니까? (1. 예\t2. 아니오)");
                        int difficulty = int.Parse(Console.ReadLine());
                        if (difficulty == 1)
                        {
                            Console.WriteLine("난이도를 다시 설정합니다.");
                            break;
                        }
                        else if (difficulty == 2)
                        {
                            Console.WriteLine("다시 하시겠습니까? (1. 예\t2. 아니오)");
                            int reTry = int.Parse(Console.ReadLine());
                            if (reTry == 1)
                            {
                                continue;
                            }
                            else if (reTry == 2)
                            {
                                Console.WriteLine("프로그램을 종료합니다.");
                                break;
                            }
                        }
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

        public void MiddleLevel() //난이도 중 메서드
        {
            Logic logic = new Logic();
            while (true)
            {
                float win = 0, lose = 0;
                logic.MLevelLogic(ref win, ref lose);
                Console.WriteLine("=============================================");
                Console.WriteLine($"총 문제 수: {win + lose} \t 정답 수: {win}승 \t 오답 수:{lose}패");
                Console.WriteLine($"정답률: {win / (win + lose) * 100}%");
                Console.WriteLine("=============================================");
                try
                {
                    if ((win / (win + lose) * 100) >= 80)
                    {
                        Console.WriteLine("난이도를 다시 설정하시겠습니까? (1. 예\t2. 아니오)");
                        int difficulty = int.Parse(Console.ReadLine());
                        if (difficulty == 1)
                        {
                            Console.WriteLine("난이도를 다시 설정합니다.");
                            break;
                        }
                        else if (difficulty == 2)
                        {
                            Console.WriteLine("다시 하시겠습니까? (1. 예\t2. 아니오)");
                            int reTry = int.Parse(Console.ReadLine());
                            if (reTry == 1)
                            {
                                continue;
                            }
                            else if (reTry == 2)
                            {
                                Console.WriteLine("프로그램을 종료합니다.");
                                break;
                            }
                        }
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        public void LowLevel() //난이도 하 메서드
        {
            Logic logic = new Logic();
            while (true)
            {
                float win = 0, lose = 0;
                logic.LLevelLogic(ref win, ref lose);
                Console.WriteLine("=============================================");
                Console.WriteLine($"총 문제 수: {win + lose} \t 정답 수: {win}승 \t 오답 수:{lose}패");
                Console.WriteLine($"정답률: {win / (win + lose) * 100}%");
                Console.WriteLine("=============================================");
                try
                {
                    if ((win / (win + lose) * 100) >= 80)
                    {
                        Console.WriteLine("난이도를 다시 설정하시겠습니까? (1. 예\t2. 아니오\t3. 종료)");
                        int difficulty = int.Parse(Console.ReadLine());
                        if (difficulty == 1)
                        {
                            Console.WriteLine("난이도를 다시 설정합니다.");
                            break;
                        }
                        else if (difficulty == 2)
                        {
                            Console.WriteLine("다시 시작합니다.");
                            continue;
                        }
                        else if(difficulty == 3)
                        {
                            Console.WriteLine("처음 메뉴로 돌아갑니다.");
                            break;
                        }
                    }
                    else if((win / (win + lose) * 100) <= 80)
                    {
                        Console.WriteLine("다시 하시겠습니까? (1. 예\t2. 아니오)");
                        int reTry = int.Parse(Console.ReadLine());
                        if (reTry == 1)
                        {
                            continue;
                        }
                        else if (reTry == 2)
                        {
                            Console.WriteLine("처음 메뉴로 돌아갑니다.");
                            break;
                        }
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        private void WinningRate(Logic logic, out float win, out float lose) //승률 메서드
        {
            win = 0;
            lose = 0;
            logic.HLevelLogic(ref win, ref lose);
            Console.WriteLine("=============================================");
            Console.WriteLine($"총 문제 수: {win + lose} \t 정답 수: {win} \t 오답 수:{lose}");
            Console.WriteLine($"정답률: {win / (win + lose) * 100}%");
            Console.WriteLine("=============================================");
        }
    }
}
