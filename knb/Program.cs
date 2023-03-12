using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace кнб
{
    internal class Program
    {
        static void Main(string[] args)
        {


//ur score, computer score
            int us = 0; int cs = 0;
            string[] knb = { "камень", "ящерица", "спок", "ножницы", "бумага" };

            for (int i = 1; i < 4; i++)
            {

                Console.Write($"\n                                            Раунд {i}" +
                    $" \n 0 - камень   1 - ящeрица    2 - спок    3 - ножницы    4 - бумага\n ваш ход: ");
                int u = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"                {knb[u]}");

                Random rnd = new Random();
                int c = rnd.Next(0, 4);
                Console.WriteLine($"ход компьютера: {knb[c]}\n");
 //check

                if (c == u) { Console.WriteLine("                                       ничья"); }                                                        
                else
                {
                    switch(u)
                    {
                        case 0:
                            {
                                if (c == 1 || c == 3) { us++; Console.WriteLine($"                                       Счет: вы - {us}   комп - {cs}"); }
                                else { cs++; Console.WriteLine($"                                       Счет: вы - {us}   комп - {cs}"); }
                                break;
                            }
                        case 1:
                            {
                                if (c == 2 || c == 4) { us++; Console.WriteLine($"                                       Счет: вы - {us}   комп - {cs}"); }
                                else { cs++; Console.WriteLine($"                                       Счет: вы - {us}   комп - {cs}"); }
                                break;
                            }
                        case 2:
                            {
                                if (c == 3 || c == 0) { us++; Console.WriteLine($"                                       Счет: вы - {us}   комп - {cs}"); }
                                else { cs++; Console.WriteLine($"                                       Счет: вы - {us}   комп - {cs}"); }
                                break;
                            }
                        case 3:
                            {
                                if (c == 4 || c == 1) { us++; Console.WriteLine($"                                       Счет: вы - {us}   комп - {cs}"); }
                                else { cs++; Console.WriteLine($"                                       Счет: вы - {us}   комп - {cs}"); }
                                break;
                            }
                        case 4:
                            {
                                if (c == 0 || c == 2) { us++; Console.WriteLine($"                                       Счет: вы - {us}   комп - {cs}"); }
                                else { cs++; Console.WriteLine($"                                       Счет: вы - {us}   комп - {cs}"); }
                                break;
                            }


                    }
                }
            }

//end
            Console.Write("_________________________________________________________________________________________________________________");
            if (cs < us) { Console.WriteLine("                                       вы победили"); }
            else if (cs > us) { Console.WriteLine("                                       вы проиграли"); }
            else { Console.WriteLine("                                       ничья"); }


            Console.ReadLine();


        }
    }
}
