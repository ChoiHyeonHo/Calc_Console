using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Console
{
    class Logic
    {
        Calc calc = new Calc();
        private void CommonM(ref float win, ref float lose, out string oper, int symbol, int alphaNum, int betaNum)
        {
            if (symbol == 1)
                calc.PlusM(ref win, ref lose, out oper, alphaNum, betaNum);
            else if (symbol == 2)
                calc.MinusM(ref win, ref lose, out oper, alphaNum, betaNum);
            else if (symbol == 3)
                calc.DivisionM(ref win, ref lose, out oper, alphaNum, betaNum);
            else
                calc.MultipM(ref win, ref lose, out oper, alphaNum, betaNum);
        }
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
                CommonM(ref win, ref lose, out oper, symbol, alphaNum, betaNum);

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
                CommonM(ref win, ref lose, out oper, symbol, alphaNum, betaNum);
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
                CommonM(ref win, ref lose, out oper, symbol, alphaNum, betaNum);
            }
        }
    }
}

