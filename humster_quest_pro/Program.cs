int dlina = 10;
int hp = 100;
int uvazh = 20;
int ves = 30;
bool den = true;
string deistv, deistv_2;
int fight;
Random rnd = new Random();
int win;
while ((uvazh < 100) & (hp > 0) & (ves > 0) & (dlina > 0) & (uvazh > 0))
{
    if (den)
    {
        Console.WriteLine("Ваши статы: \n Длина норы = {0} \n Здоровье = {1} \n Уважение = {2} \n Вес = {3} ", dlina, hp, uvazh, ves);
        Console.WriteLine("Что делать?");
        Console.WriteLine("1: Копать нору");
        Console.WriteLine("2: Поесть травки");
        Console.WriteLine("3: Пойти подраться \n4: Пойти поспать ");
        deistv = Console.ReadLine();
        switch (deistv)
        {
            case "1":
                Console.WriteLine("Как копать? \n 1: Интенсивно: Д + 5, З - 30 \n 2: Лениво: Д+2, З-10");
                deistv_2 = Console.ReadLine();
                switch (deistv_2)
                {
                    case "1":
                        dlina = dlina + 5;
                        hp = hp - 30;
                        break;
                    case "2":
                        dlina = dlina + 2;
                        hp = hp - 10;
                        break;
                }
                break;
            case "2":
                {
                    Console.WriteLine("Какой травки поесть? \n 1: Жухлой: З+10, В+15 \n 2: Зеленой: (Если У<30, то З-30 (лохов не пускают на лужайку) \t Если У>=30, то З+30, В+30) ");
                    deistv_2 = Console.ReadLine();
                    switch (deistv_2)
                    {
                        case "1":
                            hp = hp + 10;
                            ves = ves + 15;
                            break;
                        case "2":
                            if (uvazh < 30) 
                            {
                                hp = hp - 30;
                            }
                            else
                            {
                                hp = hp + 30;
                                ves = ves + 30;
                            }
                            break;
                    }
                    break;
                }
            case "3":
                {
                    Console.WriteLine("С каким существом вы хотите драться?\n 1: Со слабым существом (вес 30)\n 2: Со средним существом (вес 50) \n 3: С сильным существом (вес 70) ");
                    deistv_2=Console.ReadLine();
                    switch (deistv_2)
                    {
                        case "1":
                            fight = ves + 30;
                            win = rnd.Next(0, fight);
                            if (win <= ves)
                            {
                                if (ves <= 30)
                                {
                                    Console.WriteLine("Победа, вы получили 5 уважения");
                                    uvazh = uvazh + 5;
                                }
                                else
                                {
                                    Console.WriteLine("Победа, вы получили 10 уважения");
                                    uvazh = uvazh + 10;
                                }
                            }
                            else
                            {
                                if (ves <= 30)
                                {
                                    Console.WriteLine("Вы проиграли и потеряли 5 здоровья");
                                    hp = hp - 5;
                                }
                                else
                                {
                                    Console.WriteLine("Вы проиграли и потеряли 10 здоровья");
                                    hp = hp - 10;
                                }
                            }
                            break;
                        case "2":
                            fight = ves + 50;
                            win = rnd.Next(0, fight);
                            if (win <= ves)
                            {
                                if (ves <= 50)
                                {
                                    Console.WriteLine("Победа, вы получили 10 уважения");
                                    uvazh = uvazh + 15;
                                }
                                else
                                {
                                    Console.WriteLine("Победа, вы получили 20 уважения");
                                    uvazh = uvazh + 20;
                                }
                            }
                            else
                            {
                                if (ves <= 30)
                                {
                                    Console.WriteLine("Вы проиграли и потеряли 10 здоровья");
                                    hp = hp - 10;
                                }
                                else
                                {
                                    Console.WriteLine("Вы проиграли и потеряли 20 здоровья");
                                    hp = hp - 20;
                                }
                            }
                            break;
                        case "3":
                            fight = ves + 70;
                            win = rnd.Next(0, fight);
                            if (win <= ves)
                            {
                                if (ves <= 70)
                                {
                                    Console.WriteLine("Победа, вы получили 20 уважения");
                                    uvazh = uvazh + 20;
                                }
                                else
                                {
                                    Console.WriteLine("Победа, вы получили 40 уважения");
                                    uvazh = uvazh + 40;
                                }
                            }
                            else
                            {
                                if (ves <= 30)
                                {
                                    Console.WriteLine("Вы проиграли и потеряли 20 здоровья");
                                    hp = hp - 20;
                                }
                                else
                                {
                                    Console.WriteLine("Вы проиграли и потеряли 40 здоровья");
                                    hp = hp - 40;
                                }
                            }
                            break;

                    }
                    break;
                }
            case "4":
                den = false;
                break;

        }
        den = false;
    }
    else
    {
        dlina -= 2;
        hp -= 20;
        uvazh -= 2;
        ves -= 5;
        den = true;
    }
}
if (uvazh >= 100)
{
    Console.WriteLine("Поздравляю, вы супер_про_хомяк");
}
else
{
    Console.WriteLine("Вы проиграли.");

}
