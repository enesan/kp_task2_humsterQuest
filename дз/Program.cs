using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    internal class Program
    {
        static void Main(string[] args)
        {




            int len = 10; int res = 20; int wei = 30; int hp = 100;
            int day = 1;

            void stats()
            { Console.WriteLine($"                                                              длина норы:{len}   уважение:{res}    вес:{wei}   здоровье:{hp}"); }


            void night()
            { len -= 2; hp += 20; res -= 2; wei -= 5;
                stats();
            }


            void reznya()
            {
                Console.WriteLine("выберите противника (введите вес): 30 - слабый  50 - средний  70 - сильный");
                int wp = Convert.ToInt32(Console.ReadLine());

                //dz dw du - разница в хп, весе, уважении; р определяет победу или проигрыш
                Random rnd = new Random();
                int p = rnd.Next(0, wp + wei);

                int dw = wp - wei; int du; int dz;

                if (8 * p <= 10 * wei)
                {
                    if (dw >= 60)
                        du = 60;
                    else if (20 < dw && dw < 60)
                        du = 40;
                    else if (0 <= dw && dw <= 20)
                        du = 25;
                    else if (-40 < dw && dw <= 0)
                        du = 15;
                    else if (-80 < dw && dw <= -40)
                        du = 10;
                    else
                    { du = 5; }
                    res += du;
                    Console.WriteLine($"победа: уважение +{du}");
                }
                else
                {
                    if (dw >= 60)
                        dz = 70;
                    else if (20 < dw && dw < 60)
                        dz = 45;
                    else if (0 <= dw && dw <= 20)
                        dz = 30;
                    else if (-40 < dw && dw <= 0)
                        dz = 15;
                    else if (-80 < dw && dw <= -40)
                        dz = 10;
                    else
                    { dz = 5; }
                    hp -= dz;
                    Console.WriteLine($"вам надрали зад: здоровье -{dz}");
                }
            }



//START

            for (int i = 0; true; i++)
            {
                Console.WriteLine($"\n________________________________________________________________________________________________________________________" +
                                    $"\n          День {day}\n");            
                stats();

                Console.WriteLine($"выберите действие:\n 1 - копать нору ИНТЕНСИВНО(+5 длина норы; -30 здоровье) \n 2 - копать нору ЛЕНИВО(+2 длина норы; -10 здоровье) \n 3 - поесть ЖУХЛОЙ травы(+10 здоровье; +15 вес) \n 4 - поесть ЗЕЛЕНОЙ травы(+30 здоровье; +30 вес; если уважение < 30, то здоровье -30) \n 5 - УБИВАТЬ КРОМСАТЬ \n 6 - поспать(-2 длина норы; +20 здоровье; -2 уважение; -5 вес) \n");

//input                
                int act = Convert.ToInt32(Console.ReadLine());  
                if (act == 1) { len += 5; hp -= 30; }
                if (act == 2) { len += 2; hp -= 10;}
                if (act == 3) { hp += 10; wei += 15; }
                if (act == 4)
                {
                    if (res < 30) { hp -= 30; Console.WriteLine("лохов на лужайку не пускают, вас избили в подворотне"); }
                    else
                    {
                        hp += 30; wei += 30;
                    }
                }
                if (act == 5) { reznya(); }
                if (act == 6) { night(); }
                

                    stats();

//check1
                    if (res <= 0 || wei <= 0 || hp <= 0 || len <= 0)
                    { 
                        Console.WriteLine("О нет, один из показателей упал до 0!");
                        break;
                    }

                    if (res >= 100)
                    {
                        Console.WriteLine("Уважение достигло 100!");
                        break;
                    }

//night
                    Console.WriteLine("          Ночь");
                    night();




//check2
                    if (res <= 0 || wei <= 0 || hp <= 0 || len <= 0)
                    {
                        Console.WriteLine("О нет, один из показателей упал до 0!");
                        break;
                    }
                day++;
                }

// for ends
            if (res <= 0 || wei <= 0 || hp <= 0 || len <= 0)
                Console.WriteLine("                                                 ВЫ ПРОИГРАЛИ ");
            else { Console.WriteLine("                                                  ПОБЕДА \n                                             вы самый четкий кролик на районе "); }

            Console.WriteLine($"Прожито: {day} дн.");
                
            
            
            
            
            
            
            Console.ReadLine();


        }
    }
}
