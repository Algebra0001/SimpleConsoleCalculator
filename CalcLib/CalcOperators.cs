using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLib
{
    public class CalcOperators
    {
        /*
        /// <summary>
        /// The addition operation adds two numbers an returns the added value
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>*/
        /// 
        public double Addition(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        /// <summary>
        /// The subtraction operation subtracts the second parameter from the first parameter and return the gotten value
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public double Subtraction(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        /// <summary>
        /// The division operation divides the first parameter with the second parameter and returns the gotten value
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public double Division(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }

        /// <summary>
        /// The  multiplication operation multiplies the first parameter and the second parameter and return the result
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }


        public double Calc(int sign, double firstNum, double secondNum)
        {
            switch (sign)
            {
                case 1: return this.Addition(firstNum, secondNum);
                case 2: return this.Subtraction(firstNum, secondNum);
                case 3: return this.Multiply(firstNum, secondNum);
                case 4: return this.Division(firstNum, secondNum);
            }

            return 0;
        }
    }
}
