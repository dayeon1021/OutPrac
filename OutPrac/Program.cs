using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("사용자 입력 : ");
            int output;
            bool reault = int.TryParse(
                Console.ReadLine(),
                out output);
            if (reault)
            {
                Console.WriteLine("값 : " + output);
            }
            else
            {
                Console.WriteLine("정수를 입력하세요");
            }
        }
    }
}
