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
            Level lv = new Level();
            
            
            while (true)
            {
                lv.ShowMenu();
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: lv.HighLevel(); break;
                        case 2: lv.MiddleLevel(); break;
                        case 3: lv.LowLevel(); break;
                        case 4: Console.WriteLine("프로그램을 종료합니다."); return;
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message + "처음 화면으로 돌아갑니다.");
                }
            }
        }
    }
}
