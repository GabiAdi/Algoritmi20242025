using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16092024
{
    internal class Program
    {

        public struct operacija
        {
            public int b1, b2;
            public char op;
        }

        static int izracunajRezultat(int b1, int b2, char op) {
            if (op == '+')
            {
                return b1 + b2;
            }
            if (op == '-')
            {
                return b1 - b2;
            }
            if (op == '*')
            {
                return b1 * b2;
            }
            if (op == '/')
            {
                if (b2 == 0)
                {
                    return 0;
                }
                return b1 / b2;
            }
            return 0;
        }

        static int charToInt(char c)
        {
            return (int)(c - '0');
        }

        static int stringToInt(string str, int start, int end) 
        {
            int output = 0;
            for(int i = start; i < end; i++)
            {
                output *= 10;
                output += charToInt(str[i]);
            }
            return output;
        }
        static operacija stringToOperacija(string str)
        {
            operacija oper = new operacija();
            for(int i=0; i<str.Length; i++)
            {
                if(str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '/')
                {
                    oper.b1 = stringToInt(str, 0, i);
                    oper.b2 = stringToInt(str, i+1, str.Length);
                    oper.op = str[i];
                }
            }
            return oper;
        }

        static void Main(string[] args)
        {
            operacija oper = new operacija();
            string input;
            input = Console.ReadLine();
            oper = stringToOperacija(input);
            Console.WriteLine(izracunajRezultat(oper.b1, oper.b2, oper.op));
            Console.ReadLine();
        }
    }
}
