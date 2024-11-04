using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07102024 {
    internal class Program {

        static int brojZn(int n) {
            if(n == 0) 
                return 0;
            return n%10+brojZn(n/10);
        }


        static void Main(string[] args) {
            Console.WriteLine(brojZn(12444));
        }
    }
}