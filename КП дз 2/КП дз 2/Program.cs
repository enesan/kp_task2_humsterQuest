// See https://aka.ms/new-console-template for more information

int dlina = 10;
int health = 100;
int respect = 20;
int weight = 30;
int den = 1;
int deistv, deistv_2;
Random rand = new Random();
int win;int sumWeight;

while ((respect < 100) && (health > 0) && (weight > 0) && (dlina > 0) && (respect > 0))
{
    if (den == 1)
    {
        Console.WriteLine("Ваши статы: \n Длина норы = {0} \n Здоровье = {1} \n Уважение = {2} \n Вес = {3} ", dlina, health, respect, weight);
        Console.WriteLine("Ваши действия: ");
        Console.WriteLine("1) Копать нору");
        Console.WriteLine("2) Поесть травки");
        Console.WriteLine("3) Пойти подраться");
        Console.WriteLine("4) Проспать весь день ");
        deistv = Convert.ToInt32(Console.ReadLine());
        switch (deistv)
        {
            case 1:
                Console.WriteLine("Как копать? \n 1: Интенсивно: Д + 5, З - 30 \n 2: Лениво: Д+2, З-10");
                deistv_2 = Convert.ToInt32(Console.ReadLine());
                switch (deistv_2)
                {
                    case 1:
                        dlina = dlina + 5;
                        health = health - 30;
                        break;
                    case 2:
                        dlina = dlina + 2;
                        health = health - 10;
                        break;
                }
                break;
            case 2:
                {
                    Console.WriteLine("Какой травки поесть? \n 1: Жухлой: З+10, В+15 \n 2: Зеленой: (Если У<30, то З-30 (лохов не пускают на лужайку) \t Если У>=30, то З+30, В+30) ");
                    deistv_2 = Convert.ToInt32(Console.ReadLine());
                    switch (deistv_2)
                    {
                        case 1:
                            health = health + 10;
                            weight = weight + 15;
                            break;
                        case 2:
                            if (respect < 30)
                            {
                                health = health - 30;
                            }
                            else
                            {
                                health = health + 30;
                                weight = weight + 30;
                            }
                            break;
                    }
                    break;
                }
            case 3:
                {
                    Console.WriteLine("С каким существом вы хотите драться?\n 1: Со слабым существом (вес 30)\n 2: Со средним существом (вес 50) \n 3: С сильным существом (вес 70) ");
                    deistv_2 = Convert.ToInt32(Console.ReadLine());
                    switch (deistv_2)
                    {
                        case 1:
                            sumWeight = weight + 30;
                            win = rand.Next(0, sumWeight);

                            if (weight >= win)
                            {
                                if (weight >= 30)
                                {
                                    Console.WriteLine("Победа, вы получили +5 уважения");
                                    respect = respect + 5;
                                }
                                else
                                {
                                    Console.WriteLine("Победа, вы получили +10 уважения");
                                    respect = respect + 10;
                                }
                            }

                            else
                            {
                                if (weight >= 30)
                                {
                                    Console.WriteLine("Вы проиграли и потеряли 5 здоровья");
                                    health = health - 5;
                                }
                                else
                                {
                                    Console.WriteLine("Вы проиграли и потеряли 10 здоровья");
                                    health = health - 10;
                                }
                            }
                            break;

                        case 2:
                            sumWeight = weight + 50;
                            win = rand.Next(0, sumWeight);
                            if (weight >= win )
                            {
                                
                                if(weight >= 50 * 2)
                                {
                                    Console.WriteLine("Победа, вы получили +5 уважения");
                                    respect = respect + 5;
                                }

                                else if (weight >= 50)
                                {
                                    Console.WriteLine("Победа, вы получили +10 уважения");
                                    respect = respect + 10;
                                }

                                else
                                {
                                    Console.WriteLine("Победа, вы получили +20 уважения");
                                    respect = respect + 20;
                                }
                            }
                            else
                            {
                                if (weight >= 50 * 2)
                                {
                                    Console.WriteLine("Вы проиграли и потеряли 5 здоровья");
                                    health = health - 5;
                                }

                                else if (weight >= 50)
                                {
                                    Console.WriteLine("Вы проиграли и потеряли 10 здоровья");
                                    health = health - 10;
                                }

                                else
                                {
                                    Console.WriteLine("Вы проиграли и потеряли 20 здоровья");
                                    health = health - 20;
                                }
                            }
                            break;
                        case 3:
                            sumWeight = weight + 70;
                            win = rand.Next(0, sumWeight);
                            if (weight >= win)
                            {
                    
                                if (weight >= 70 * 2)
                                {
                                    Console.WriteLine("Победа, вы получили +5 уважения");
                                    respect = respect + 5;
                                }

                                else if (weight >= 70)
                                {
                                    Console.WriteLine("Победа, вы получили +20 уважения");
                                    respect = respect + 20;
                                }

                                else
                                {
                                    Console.WriteLine("Победа, вы получили +40 уважения");
                                    respect = respect + 40;
                                }
                            }
                            else
                            {
                                if (weight >= 70*2)
                                {
                                    Console.WriteLine("Вы проиграли и потеряли 5 здоровья");
                                    health = health - 5;
                                }

                                else if (weight >= 70)
                                {
                                    Console.WriteLine("Вы проиграли и потеряли 20 здоровья");
                                    health = health - 20;
                                }
                                else
                                {
                                    Console.WriteLine("Вы проиграли и потеряли 40 здоровья");
                                    health = health - 40;
                                }
                            }
                            break;
                    }
                    break;
                }
            case 4:
                den = 0;
                break;

        }
        den = 0;
    }
    else
    {
        dlina = dlina -2;
        health = health + 5;
        respect = respect -2;
        weight = weight-5;
        den = 1;
    }
}
if (respect >= 100) Console.WriteLine("Поздравляем , вы выиграли ");

else Console.WriteLine("Вы проиграли");

