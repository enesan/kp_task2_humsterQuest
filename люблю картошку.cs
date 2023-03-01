using System;
using System.Diagnostics.Metrics;

int length = 10;
int health = 100;
int respect = 20;
double weight = 30.0;
int day_or_night = 1;
Random rand = new Random();
void print()
{
    Console.WriteLine();
    Console.WriteLine($"Длина твоей норы: {length}");
    Console.WriteLine($"Твоё здоровье: {health}");
    Console.WriteLine($"Твоё уважение: {respect}");
    Console.WriteLine($"Твой вес: {weight}");
    Console.WriteLine();
}

Console.WriteLine("Добро пожаловать! Представь, что однажды утром ты проснулся и стал тараканом. Вот твои характеристики:");
print();
Console.WriteLine("Ты еще не свой среди тараканов, так что придется тебе набрать уважение (100). Не дай упасть другим показателям!");
Console.WriteLine();

while ((length > 0) & (health > 0) & (respect < 100) & (weight > 0))
{
    while (day_or_night == 1)
    {
        Console.WriteLine("Наступил день. Напоминаю, твои характеристики на данный момент:");
        print();
        Console.WriteLine("Чем же ты займешься сегодня? Выбери цифру.");
        Console.WriteLine();
        Console.WriteLine("1: копать нору");
        Console.WriteLine("2: поесть травку");
        Console.WriteLine("3: пойти драться");
        Console.WriteLine("4: поспать весь день");
        Console.WriteLine();
        int change = Convert.ToInt32(Console.ReadLine());
        switch (change)
        {
            case 1:
                Console.WriteLine();
                Console.WriteLine("Как ты хочешь копать?");
                Console.WriteLine("1: интенсивно");
                Console.WriteLine("2. лениво");
                Console.WriteLine();
                int change_kopat = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (change_kopat)
                {
                    case 1:
                        Console.WriteLine("А ты хорош! Твои характеристики потерпели небольшие изменения:");
                        length += 5;
                        health -= 30;
                        print();
                        break;
                    case 2:
                        Console.WriteLine("Не думал, что ты лентяй! Твои характеристики чуть изменились:");
                        length += 2;
                        health -= 10;
                        print();
                        break;
                }
                break;
            case 2:
                Console.WriteLine("Выбирай, какую травку ты будешь кушать:");
                Console.WriteLine();
                Console.WriteLine("1: жухлую");
                Console.WriteLine("2: зеленую");
                Console.WriteLine();
                int change_grass = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (change_grass)
                {
                    case 1:
                        Console.WriteLine("Трава, конечно, отстой. Но что поделать... Твои характеристики:");
                        health += 10;
                        weight += 15;
                        print();
                        break;
                    case 2:
                        if (respect < 30)
                        {
                            Console.WriteLine("Чел... Лохов на лужайки не пускают, тебя за это побили. Твои характеристики:");
                            health -= 30;
                            print();
                        }
                        if (respect >= 30)
                        {
                            Console.WriteLine("Лучшая лужайка угощает! Твои характеристики:");
                            health += 30;
                            weight += 30;
                            print();
                        }
                        break;
                }
                break;
            case 3:
                Console.WriteLine("С кем хочешь подраться?");
                Console.WriteLine();
                Console.WriteLine("1: с лохом");
                Console.WriteLine("2: со среднячком");
                Console.WriteLine("3: с крутым тараканом на районе");
                Console.WriteLine();
                int change_enemy = Convert.ToInt32(Console.ReadLine());
                switch (change_enemy)
                {
                    case 1:
                        double randomchic = rand.NextDouble();
                        if (randomchic >= weight / (30 + weight))
                        {
                            if (weight > 30)
                            {
                                Console.WriteLine("Слабых бить не очень, но ты выиграл, твои показатели изменились...");
                                health -= 15;
                                respect += 5;
                                print();
                            }
                            if (weight == 30)
                            {
                                Console.WriteLine("Неплохо))) Твои показатели изменились!");
                                health -= 35;
                                respect += 20;
                                print();
                            }
                            if (weight < 30)
                            {
                                Console.WriteLine("Да ты мощь!!! Твои показатели поменялись!");
                                health -= 70;
                                respect += 40;
                                print();
                            }
                        }
                        if (randomchic < weight / (30 + weight))
                        {
                            if (weight > 30)
                            {
                                Console.WriteLine("Ну ты и лох... Проиграть такому лошку...");
                                health -= 15;
                                respect -= 15;
                                print();
                            }
                            if (weight == 30)
                            {
                                Console.WriteLine("Не повезло... Но ты не расстраивайся с;");
                                health -= 35;
                                print();
                            }
                            if (weight < 30)
                            {
                                Console.WriteLine("Попытка - не пытка! Хотя, кажется, не в твоем случае... Ты ведь чуть не помер");
                                health -= 70;
                                respect += 10;
                            }
                        }
                        break;
                    case 2:
                        double randomchic1 = rand.NextDouble();
                        if (randomchic1 >= weight / (30 + weight))
                        {
                            if (weight > 50)
                            {
                                Console.WriteLine("Молодец, твои показатели изменились! Но не пора ли сразиться с кем-то более сильным?");
                                health -= 15;
                                respect += 5;
                                print();
                            }
                            if (weight == 50)
                            {
                                Console.WriteLine("Неплохо))) Твои показатели изменились!");
                                health -= 35;
                                respect += 20;
                                print();
                            }
                            if (weight < 50)
                            {
                                Console.WriteLine("Скоро пойдешь на рейд к крутому таракану на районе!!! Твои показатели поменялись!");
                                health -= 70;
                                respect += 40;
                                print();
                            }
                        }
                        if (randomchic1 < weight / (50 + weight))
                        {
                            if (weight > 50)
                            {
                                Console.WriteLine("Не так грустно проиграть противнику, который уже бывалый. В следущий раз у тебя точно получится!");
                                health -= 15;
                                respect -= 15;
                                print();
                            }
                            if (weight == 50)
                            {
                                Console.WriteLine("Не повезло... Но ты не расстраивайся с;");
                                health -= 35;
                                print();
                            }
                            if (weight < 50)
                            {
                                Console.WriteLine("Попытка - не пытка! Хотя, кажется, не в твоем случае... Ты ведь чуть не помер");
                                health -= 70;
                                respect += 10;
                            }
                        }
                        break;
                    case 3:
                        double randomchic2 = rand.NextDouble();
                        if (randomchic2 >= weight / (70 + weight))
                        {
                            if (weight > 70)
                            {
                                Console.WriteLine("Ничего себе ты крут! Да ты собираешь поклонников))");
                                health -= 15;
                                respect += 25;
                                print();
                            }
                            if (weight == 70)
                            {
                                Console.WriteLine("Неплохо))) Ты победил противника равного себе! Твои показатели изменились!");
                                health -= 35;
                                respect += 35;
                                print();
                            }
                            if (weight < 70)
                            {
                                Console.WriteLine("ЧЕЕ да ты машина, а не таракан!!!");
                                health -= 70;
                                respect += 50;
                                print();
                            }
                        }
                        if (randomchic2 < weight / (70 + weight))
                        {
                            if (weight > 70)
                            {
                                Console.WriteLine("Не так грустно проиграть противнику, который уже бывалый. В следущий раз у тебя точно получится!");
                                health -= 15;
                                respect -= 15;
                                print();
                            }
                            if (weight == 70)
                            {
                                Console.WriteLine("Не повезло... Но ты не расстраивайся с;");
                                health -= 35;
                                print();
                            }
                            if (weight < 70)
                            {
                                Console.WriteLine("Попытка - не пытка! Хотя, кажется, не в твоем случае... Ты ведь чуть не помер");
                                health -= 70;
                                respect += 10;
                            }
                        }
                        break;
                }
                break;
            case 4:
                Console.WriteLine("Дрыхнешь посреди дня...");
                Console.WriteLine();
                length -= 2;
                health += 10;
                respect -= 2;
                weight -= 5;
                print();
                break;
        }
        day_or_night -= 1;
    }
    while (day_or_night == 0)
    {
        Console.WriteLine("Белая ночь опустилась как облако...");
        Console.WriteLine();
        Console.WriteLine("Твои характеристики чуть изменились!");
        length -= 2;
        health += 10;
        respect -= 2;
        weight -= 5;
        print();
        day_or_night += 1;
    }
}

if ((length <= 0) | (health <= 0) | (weight <= 0))
{
    Console.WriteLine("All my friends are toxic... Ты проиграл :с");
}
if (respect >= 100)
{
    Console.WriteLine("Ура, победа!!! Поздравляю!!! Самый уважаемый таракан на районе)))");
}