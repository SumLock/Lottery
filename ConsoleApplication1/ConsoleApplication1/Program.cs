using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // 字體顏色
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkRed;

            // 產生亂數物件
            Random rand = new Random();

            //紀錄次數
            int count = 0;

            // 迴圈重複產生
            while (count < 10)
            {
                // 產生6個亂數
                int r1 = rand.Next(0, 43);
                int r2 = rand.Next(0, 43);
                int r3 = rand.Next(0, 43);
                int r4 = rand.Next(0, 43);
                int r5 = rand.Next(0, 43);
                int r6 = rand.Next(0, 43);

                // 
                Console.WriteLine(" [{0:00}]  {1:00} {2:00} {3:00} {4:00} {5:00}", count, r1, r2, r3, r4, r5, r6);

                // 迴圈一次+1
                count = count + 1;
            }

            // 停止
            Console.ReadLine();
        }
    }
}