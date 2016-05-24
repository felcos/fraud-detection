using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = 0;
            string[] linea;
            Console.WriteLine("Fraud Prevention");
            Console.WriteLine("Please enter the number of records then press <enter>");
            num = UInt16.Parse(Console.ReadLine());
            linea = new string[num+1];
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Please enter the record {0}",i);
                linea[i] = Console.ReadLine();
            }
            for (int i = 1; i <= num; i++)
            {
                string[] fraud = linea[i].Split(',');
                for (int j = i; j <= num; j++)
                {
                    string[] compare = linea[j].Split(',');
                    if ((compare[1] == fraud[1] && compare[2] == fraud[2]) || (compare[3] == fraud[3] && compare[4] == fraud[4] && compare[5] == fraud[5] && compare[6] == fraud[6]) )
                    {
                        if (compare[7] != fraud[7])
                        {
                            Console.WriteLine("{0},",i);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
