using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace кп_дз2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int den_lenght = 10, health = 100, respect = 20, weight = 30;
            Random rnd = new Random();

            while (respect < 100 && den_lenght > 0 && health > 0 && respect > 0 && weight > 0)
            {
                Console.WriteLine("\n Твои статы: \n\n Длина норы (Д) = " + den_lenght + "\n Здоровье (З) = " + health + "\n Уважение (У) = " + respect + "\n Вес (В) = " + weight + "\n");
                Console.WriteLine("День: \n \n Введи номер выбранного действия \n\n 1. Копать нору \n 2. Поесть травки \n 3. Подраться \n 4. Поспать \n");
                int choice = Convert.ToInt32(Console.ReadLine());

                //День
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Выбери интенсивность копания: \n\n 1. Усердно (Д+5, З-30) \n 2. На отвали (Д+2, З-10) \n");
                        int a = Convert.ToInt32(Console.ReadLine());
                        if (a == 1) 
                        {
                            den_lenght += 5;
                            health -= 30;
                        }
                        else 
                        {
                            den_lenght += 2;
                            health -= 10;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Выбери какую травку кушать: \n\n 1. Жухлую (З+10, В+15) \n 2. Свежую сочную (З+30, В+30 если У>30) \n");
                        a = Convert.ToInt32(Console.ReadLine());
                        if (a == 1)
                        {
                            health += 10;
                            weight += 15;
                        }
                        else if (a == 2 && respect <30)
                        {
                            Console.WriteLine("Тебя забулили \n");
                            health -= 30;
                        }
                        else
                        {
                            health += 30;
                            weight += 30;
                        }
                        break;

                        case 3:
                        Console.WriteLine("Выбери противника: \n\n 1. Слабый (В = 30) \n 2. Средний (В = 50) \n 3. Сильный (В = 70)\n");
                        a = Convert.ToInt32(Console.ReadLine());
                        if (a == 1)
                        {
                            int f = rnd.Next(30+weight);
                            if (f <= weight)
                            {
                                Console.WriteLine("Победа!!! Так держать!");
                                if (weight <= 30) { respect += 10; }
                                else { respect += 5; }
                            }
                            else
                            {
                                Console.WriteLine("Тебе надрали зад");
                                if (weight <= 30) { health -= 10; }
                                else { health -= 5; }
                            }
                        }
                        else if (a == 2)
                        {
                            int f = rnd.Next(50 + weight);
                            if (f <= weight)
                            {
                                Console.WriteLine("Победа!!! Так держать!");
                                if (weight <= 50) { respect += 20; }
                                else { respect += 10; }
                            }
                            else
                            {
                                Console.WriteLine("Тебе надрали зад");
                                if (weight <= 50) { health -= 20; }
                                else { health -= 10; }
                            }
                        }
                        else
                        {
                            int f = rnd.Next(70 + weight);
                            if (f <= weight)
                            {
                                Console.WriteLine("Победа!!! Так держать!");
                                if (weight <= 70) { respect += 40; }
                                else { respect += 20; }
                            }
                            else
                            {
                                Console.WriteLine("Тебе надрали зад");
                                if (weight <= 30) { health -= 40; }
                                else { health -= 20; }
                            }
                        }
                        break;

                        case 4:
                        den_lenght -= 2;
                        health += 20;
                        respect -= 2;
                        weight -= 5;
                        break;
                }

                //Ночь
                den_lenght -= 2;
                health += 20;
                respect -= 2;
                weight -= 5;
            }

            if(respect == 100) { Console.WriteLine("Ты стал самым уважаемым на районе"); }
            else { Console.WriteLine("Ты сдох"); }
        }
    }
}
