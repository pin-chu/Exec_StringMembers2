using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Q6根據日期，傳回今天是本月上旬中旬或下旬

            int start3 = Convert.ToInt32(DateTime.Now.ToString("dd"));
            if (start3 <= 10)
            {
                Console.WriteLine("上旬");
            }
            else if (start3 > 10 && start3 <= 20)
            {
                Console.WriteLine("中旬");
            }
            else
            {
                Console.WriteLine("下旬");
            }
            
            //Q7根據不同時間，傳回不同問安方式

            int start4 = Convert.ToInt32(DateTime.Now.ToString("HH"));
            if (start4 > 6 && start4 < 12)
            {
                Console.WriteLine("早安");
            }
            else if (start4 > 12 && start4 <= 18)
            {
                Console.WriteLine("午安");
            }
            else
            {
                Console.WriteLine("晚安");
            }
             
        }     
    }
}
