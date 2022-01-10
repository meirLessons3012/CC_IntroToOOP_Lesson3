using System;

namespace HWS_IntroToOOP_Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // commnet current line

            /*
             * long comment
             */
            int i = 5;
            string ss = "C:\\Windows";
            const int i2 = 0;
            Console.WriteLine(ss);
            Console.WriteLine();
            

            //Console.WriteLine(-1 / i2);
            //Console.WriteLine(i / i2);
            int result = CalcTwoNumbers(3,7);
            Console.WriteLine(result);
        }

        /// <summary>
        /// that method calc two number with + operator
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static int CalcTwoNumbers(int n1, int n2)
        {
            return n1 + n2;
        }

        //public static int CalcTwoNumbers(int n1, int n2)
        //{
        //    return n1 - n2;
        //}
    }

    internal class Program1
    {

    }
}
