using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR _Week10_2");
            string ans = "yes";
            while (ans == "yes")
            {
                Console.Write("請輸入時薪值:");
                string salaryStr = Console.ReadLine();
                int salary = int.Parse(salaryStr);
                if (salary >= 120)
                {
                    Console.WriteLine("時薪:{0}，高時薪", salary);
                }
                else
                {
                    Console.WriteLine("時薪:{0}，低時薪", salary);
                }
                Console.Write("請輸入\"yes\"繼續計算，其它任意鍵離開:");
                ans = Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
