using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30092024 {
    internal class Program {
        static void Main(string[] args) {
            string[] arr;
            string s = "Top 10 tekstova";
            arr = s.Split();
            Console.WriteLine(s.ElementAt(0));
            foreach (string s2 in arr) {
                Console.WriteLine(s2);
            }
        }
    }
}
