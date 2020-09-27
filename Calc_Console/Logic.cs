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
        private void CommonM(ref float win, ref float lose, out string oper, int symbol, int alphaNum, int betaNum) //공통 메서드
        {
            if (symbol == 1) // 난수 1일 경우 덧셈메서드 호출
                calc.PlusM(ref win, ref lose, out oper, alphaNum, betaNum);
            else if (symbol == 2) //난수 2일 경우 뺄셈메서드 호출
                calc.MinusM(ref win, ref lose, out oper, alphaNum, betaNum);
            else if (symbol == 3) //난수 3일 경우 나눗셈메서드 호출
                calc.DivisionM(ref win, ref lose, out oper, alphaNum, betaNum);
            else //그 외에 곱셈메서드
                calc.MultipM(ref win, ref lose, out oper, alphaNum, betaNum);
        }
        public void LLevelLogic(ref float win, ref float lose) //난이도 하 로직
        {
            for (int i = 0; i <= 4; i++)
            {
                Random rNum = new Random();
                Random oNum = new Random();

                string oper; //연산기호 선언을 위한
                int symbol = oNum.Next(1, 5); //난수 1~4에 따른 사칙연산
                int alphaNum = rNum.Next(1, 10); //첫번째 숫자 1자릿수
                int betaNum = rNum.Next(1, 10); //두번째 숫자 1자릿수
                CommonM(ref win, ref lose, out oper, symbol, alphaNum, betaNum);
            }
        }
        public void MLevelLogic(ref float win, ref float lose) //난이도 중 로직
        {
            for (int i = 0; i <= 4; i++)
            {
                Random rNum = new Random();
                Random oNum = new Random();

                string oper;
                int symbol = oNum.Next(1, 5);
                int alphaNum = rNum.Next(10, 100); //첫번째 숫자 2자릿수
                int betaNum = rNum.Next(10, 100); //두번째 숫자 2자릿수
                CommonM(ref win, ref lose, out oper, symbol, alphaNum, betaNum);
            }
        }
        public void HLevelLogic(ref float win, ref float lose) //난이도 상 로직
        {
            for (int i = 0; i <= 4; i++)
            {
                Random rNum = new Random();
                Random oNum = new Random();

                string oper;
                int symbol = oNum.Next(1, 5);
                int alphaNum = rNum.Next(100, 999); //첫번째 숫자 3자릿수
                int betaNum = rNum.Next(100, 999); //두번째 숫자 3자릿수
                CommonM(ref win, ref lose, out oper, symbol, alphaNum, betaNum);
            }
        }
    }
}

