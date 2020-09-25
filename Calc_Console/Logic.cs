using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Console
{
    class Logic
    {
        public void LLevelLogic(ref float win, ref float lose)
        {
            for (int i = 0; i <= 4; i++)
            {
                Random rNum = new Random();
                Random oNum = new Random();

                string oper;
                int symbol = oNum.Next(1, 5);
                int alphaNum = rNum.Next(1, 10);
                int betaNum = rNum.Next(1, 10);
                int result;
                CommonM(ref win, ref lose, out oper, symbol, alphaNum, betaNum, out result);
            }
        }
        public void MLevelLogic(ref float win, ref float lose)
        {
            for (int i = 0; i <= 4; i++)
            {
                Random rNum = new Random();
                Random oNum = new Random();

                string oper;
                int symbol = oNum.Next(1, 5);
                int alphaNum = rNum.Next(10, 100);
                int betaNum = rNum.Next(10, 100);
                int result;
                CommonM(ref win, ref lose, out oper, symbol, alphaNum, betaNum, out result);
            }
        }
        public void HLevelLogic(ref float win, ref float lose)
        {
            for (int i = 0; i <= 4; i++)
            {
                Random rNum = new Random();
                Random oNum = new Random();

                string oper;
                int symbol = oNum.Next(1, 5);
                int alphaNum = rNum.Next(100, 999);
                int betaNum = rNum.Next(100, 999);
                int result;
                CommonM(ref win, ref lose, out oper, symbol, alphaNum, betaNum, out result);
            }
        }
        public void CommonM(ref float win, ref float lose, out string oper, int symbol, int alphaNum, int betaNum, out int result)
        {
            if (symbol == 1)
            {
                Plus plus = new Plus();
                plus.PlusM(ref win, ref lose, out oper, alphaNum, betaNum, out result);
            }
            else if (symbol == 2)
            {
                Minus minus = new Minus();
                minus.MinusM(ref win, ref lose, out oper, alphaNum, betaNum, out result);
            }
            else if (symbol == 3)
            {
                Division division = new Division();
                division.DivisionM(ref win, ref lose, out oper, alphaNum, betaNum, out result);
            }
            else
            {
                Multip multip = new Multip();
                multip.MultipM(ref win, ref lose, out oper, alphaNum, betaNum, out result);
            }
        }
    }
}
