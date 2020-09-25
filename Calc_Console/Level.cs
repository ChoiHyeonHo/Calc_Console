using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Console
{
    class Level
    {
        bool bFlag = true;
        public void HighLevel()
        {
            Logic logic = new Logic();
            while (true)
            {
                float win = 0, lose = 0;
                logic.HLevelLogic(ref win, ref lose);
                Console.WriteLine("=============================================");
                Console.WriteLine($"총 문제 수: {win + lose} \t 정답 수: {win} \t 오답 수:{lose}");
                Console.WriteLine($"정답률: {win / (win + lose) * 100}%");
                Console.WriteLine("=============================================");
                if ((win / (win + lose) * 100) >= 80)
                {
                    Console.WriteLine("난이도를 다시 설정하시겠습니까? (1. 예\t2. 아니오)");
                    int difficulty = int.Parse(Console.ReadLine());
                    if (difficulty == 1)
                    {
                        Console.WriteLine("난이도를 다시 설정합니다.");
                        bFlag = false;
                        break;
                    }
                    else if(difficulty == 2)
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
                            return;
                        }
                    }
                }
            }
        }
        public void MiddleLevel()
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
                if (win >= 4)
                {
                    Console.WriteLine("난이도를 다시 설정하시겠습니까? (1. 예\t2. 아니오)");
                    int difficulty = int.Parse(Console.ReadLine());
                    if (difficulty == 1)
                    {
                        Console.WriteLine("난이도를 다시 설정합니다.");
                        bFlag = false;
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
                            return;
                        }
                    }
                }
            }
        }
        public void LowLevel()
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
                if (win >= 4)
                {
                    Console.WriteLine("난이도를 다시 설정하시겠습니까? (1. 예\t2. 아니오)");
                    int difficulty = int.Parse(Console.ReadLine());
                    if (difficulty == 1)
                    {
                        Console.WriteLine("난이도를 다시 설정합니다.");
                        bFlag = false;
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
                            return;
                        }
                    }
                }
            }
        }
    }
}
