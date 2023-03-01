int lenth = 10;
int health = 100;
int respect = 20;
double weight = 30.0;
int cicle = 1;
Random rand = new Random();
Console.WriteLine("Смари чел. Ты тупа червь. У тебя есть следующие характеристики:");
Console.Write($"Длина твоей норы: {lenth} \n");
Console.Write($"Твое здоровье: {health} \n");
Console.Write($"Твое уважение: {respect} \n");
Console.Write($"Твой вес: {weight} \n");
Console.WriteLine();
Console.WriteLine("И кароче. тебе нужно добиться увлажнение на 100очку и не дать себе сдохнуть от всякого неприятного... \nеще не дать твоей норе уменьшиться...и жирочек надо конечно тоже поддерживать...кароче копайся как хочешь и удачи!!");
Console.WriteLine();
while ((lenth > 0) & (health>0) & (respect < 100) & (weight>0)) { 
    while (cicle == 1)
    {
        Console.WriteLine("Наступил день");
        Console.WriteLine();
        Console.WriteLine("Твои параметры:");
        Console.Write($"Длина твоей норы: {lenth} \n");
        Console.Write($"Твое здоровье: {health} \n");
        Console.Write($"Твое уважение: {respect} \n");
        Console.Write($"Твой вес: {weight} \n");
        Console.WriteLine();
        Console.WriteLine("У тебя есть три варианта развития событий. Что ты выберешь?");
        Console.WriteLine("1. Копать нору");
        Console.WriteLine("2. Поесть травки");
        Console.WriteLine("3. Пойти подраться");
        Console.WriteLine("4. Проспать весь день");
        int change1 = Convert.ToInt32(Console.ReadLine());
        if (change1 == 1)
        {
            Console.WriteLine("Как ты хочешь копать?");
            Console.WriteLine("1. Интенсивно");
            Console.WriteLine("2. Лениво");
            int change11 = Convert.ToInt32(Console.ReadLine());
            if (change11 == 1)
            {
                Console.WriteLine("Ты классно поработал! Твои характеристики чуток поменялись!");
                lenth = lenth + 10;
                health = health - 30;
                Console.Write($"Длина твоей норы: {lenth} \n");
                Console.Write($"Твое здоровье: {health} \n");
                Console.Write($"Твое уважение: {respect} \n");
                Console.Write($"Твой вес: {weight} \n");
                Console.WriteLine();
            }
            if (change11 == 2)
            {
                Console.WriteLine("Не, ну ты лентяй конечно. Твои характеристики чуток поменялись...");
                lenth = lenth + 2;
                health = health - 10;
                Console.Write($"Длина твоей норы: {lenth} \n");
                Console.Write($"Твое здоровье: {health} \n");
                Console.Write($"Твое уважение: {respect} \n");
                Console.Write($"Твой вес: {weight} \n");
                Console.WriteLine();
            }
            cicle = cicle - 1;
        }
        if (change1 == 2)
        {
            Console.WriteLine("Какой травкой хочешь отведать сегодня?");
            Console.WriteLine("1. Жухлой");
            Console.WriteLine("2. Зеленой");
            int change12 = Convert.ToInt32(Console.ReadLine());
            if (change12 == 1)
            {
                Console.WriteLine("Трава хоть и так себе, но все равно вроде норм...и твои показатели изменились!");
                health = health + 10;
                weight = weight + 15;
                Console.Write($"Длина твоей норы: {lenth} \n");
                Console.Write($"Твое здоровье: {health} \n");
                Console.Write($"Твое уважение: {respect} \n");
                Console.Write($"Твой вес: {weight} \n");
                Console.WriteLine();
            }
            if (change12 == 2)
            {
                if (respect < 30)
                {
                    Console.WriteLine("Лохов не пускают на элитные полянки, так что тебя побили за проникновение, и твои показатели поменялись :С");
                    health = health - 30;
                    Console.Write($"Длина твоей норы: {lenth} \n");
                    Console.Write($"Твое здоровье: {health} \n");
                    Console.Write($"Твое уважение: {respect} \n");
                    Console.Write($"Твой вес: {weight} \n");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Милости просим отведать превосходной травы! После нее у вас произошли изменения!");
                    health = health + 30;
                    weight= weight + 30;
                    Console.Write($"Длина твоей норы: {lenth} \n");
                    Console.Write($"Твое здоровье: {health} \n");
                    Console.Write($"Твое уважение: {respect} \n");
                    Console.Write($"Твой вес: {weight} \n");
                    Console.WriteLine();
                }
                
            }
            cicle = cicle - 1;
        }
        if (change1==3)
        {
            Console.WriteLine("С кем хочешь подраться?");
            Console.WriteLine("1. С додиком каким-то...");
            Console.WriteLine("2. С нормисом");
            Console.WriteLine("3. С альфа-самцом");
            int change13 = Convert.ToInt32(Console.ReadLine());
            if (change13== 1)
            {
                double gener = rand.NextDouble();
                //Console.Write(gener);
                //Console.Write(weight/(30 + weight));
                if (gener >= weight / (30+weight))
                {
                    if (weight > 30)
                    {
                        Console.WriteLine("Не, ну ты конечно выиграл, да..но нападать на слабых...это низко..твои статы изменились...");
                        health = health - 15;
                        respect = respect + 5;
                        Console.Write($"Длина твоей норы: {lenth} \n");
                        Console.Write($"Твое здоровье: {health} \n");
                        Console.Write($"Твое уважение: {respect} \n");
                        Console.Write($"Твой вес: {weight} \n");
                        Console.WriteLine();
                    }
                    if (weight == 30)
                    {
                        Console.WriteLine("Блин, а ты молодец, вот так и надо, так держать! Твои параметры изменились кстати С;");
                        health = health - 35;
                        respect = respect + 20;
                        Console.Write($"Длина твоей норы: {lenth} \n");
                        Console.Write($"Твое здоровье: {health} \n");
                        Console.Write($"Твое уважение: {respect} \n");
                        Console.Write($"Твой вес: {weight} \n");
                        Console.WriteLine();
                    }
                    if (weight < 30)
                    {
                        Console.WriteLine("Капец ты наглая мощная машина! Это было опасно, но ты справился, я горжусь тобой! Твоя статистика чуток поменялась!");
                        health = health - 70;
                        respect = respect + 40;
                        Console.Write($"Длина твоей норы: {lenth} \n");
                        Console.Write($"Твое здоровье: {health} \n");
                        Console.Write($"Твое уважение: {respect} \n");
                        Console.Write($"Твой вес: {weight} \n");
                        Console.WriteLine();
                    }
                }
                if (gener < weight/(30+weight))
                {
                    if (weight > 30)
                    {
                        Console.WriteLine("Ты сильнее и мощнее этого додика...и проиграл...капец ты чмо, твои статы изменились кстати, посмотри и поплачь");
                        health = health - 15;
                        respect = respect - 15;
                        Console.Write($"Длина твоей норы: {lenth} \n");
                        Console.Write($"Твое здоровье: {health} \n");
                        Console.Write($"Твое уважение: {respect} \n");
                        Console.Write($"Твой вес: {weight} \n");
                        Console.WriteLine();
                    }
                    if (weight == 30)
                    {
                        Console.WriteLine("Ну, тут либо да, либо нет, ничего удивительного, но ты все равно не сдавайся С:");
                        health = health - 35;
                        Console.Write($"Длина твоей норы: {lenth} \n");
                        Console.Write($"Твое здоровье: {health} \n");
                        Console.Write($"Твое уважение: {respect} \n");
                        Console.Write($"Твой вес: {weight} \n");
                        Console.WriteLine();
                    }
                    if (weight < 30)
                    {
                        Console.WriteLine("Это было ожидаемо, но ты молодец, что попытался, хоть и чуть не подох С:");
                        health = health - 70;
                        respect = respect + 10;
                        Console.Write($"Длина твоей норы: {lenth} \n");
                        Console.Write($"Твое здоровье: {health} \n");
                        Console.Write($"Твое уважение: {respect} \n");
                        Console.Write($"Твой вес: {weight} \n");
                        Console.WriteLine();
                    }
                }

            }
            if (change13 == 2)
            {
                double gener = rand.NextDouble();
                //Console.Write(gener);
                //Console.Write(weight / (50 + weight));
                if (gener >= weight/(weight+50))
                {
                    if(weight > 50)
                    {
                        Console.WriteLine("Ты конечно умничка что победил, но не пора ли выбирать противников посильнее?");
                        health = health - 15;
                        respect = respect + 5;
                        Console.Write($"Длина твоей норы: {lenth} \n");
                        Console.Write($"Твое здоровье: {health} \n");
                        Console.Write($"Твое уважение: {respect} \n");
                        Console.Write($"Твой вес: {weight} \n");
                        Console.WriteLine();

                    }
                    if (weight == 50)
                    {
                        Console.WriteLine("Стабильно, четко, слаженно. Умничка, не иначе");
                        health = health - 35;
                        respect = respect + 20;
                        Console.Write($"Длина твоей норы: {lenth} \n");
                        Console.Write($"Твое здоровье: {health} \n");
                        Console.Write($"Твое уважение: {respect} \n");
                        Console.Write($"Твой вес: {weight} \n");
                        Console.WriteLine();
                    }
                    if (weight < 50)
                    {
                        Console.WriteLine("Что это, мы не знаем что это такое, мы никогда такого не видели, но ты выиграл!! Скоро ты будешь супер-пупер машиной!");
                        health = health - 70;
                        respect = respect + 40;
                        Console.Write($"Длина твоей норы: {lenth} \n");
                        Console.Write($"Твое здоровье: {health} \n");
                        Console.Write($"Твое уважение: {respect} \n");
                        Console.Write($"Твой вес: {weight} \n");
                        Console.WriteLine();
                    }
                }
                if (gener < weight / (weight + 50))
                {
                   if (weight > 50)
                    {
                        Console.WriteLine("Ну, это такой средний противник, и видимо это просто была неудача, что ты не смог побороть нормиса со своими мускулами...надеюсь этот позор больше не повторится...");
                        health = health - 15;
                        respect = respect - 5;
                        Console.Write($"Длина твоей норы: {lenth} \n");
                        Console.Write($"Твое здоровье: {health} \n");
                        Console.Write($"Твое уважение: {respect} \n");
                        Console.Write($"Твой вес: {weight} \n");
                        Console.WriteLine();
                    }
                   if (weight == 50)
                    {
                        Console.WriteLine("Ну, тут либо да, либо нет, ничего удивительного, но ты все равно не сдавайся С:");
                        health = health - 35;
                        Console.Write($"Длина твоей норы: {lenth} \n");
                        Console.Write($"Твое здоровье: {health} \n");
                        Console.Write($"Твое уважение: {respect} \n");
                        Console.Write($"Твой вес: {weight} \n");
                        Console.WriteLine();
                    }
                   if (weight < 50)
                    {
                        Console.WriteLine("Да, проиграл, но ничего, еще немного подкачаться и ты его на британский флаг порвешь!!");
                        health = health - 70;
                        respect = respect + 10;
                        Console.Write($"Длина твоей норы: {lenth} \n");
                        Console.Write($"Твое здоровье: {health} \n");
                        Console.Write($"Твое уважение: {respect} \n");
                        Console.Write($"Твой вес: {weight} \n");
                        Console.WriteLine();
                    }
                   
                }
            }
            if (change13 == 3)
            {
                double gener = rand.NextDouble();
                //Console.Write(gener);
                //Console.Write(weight / (70 + weight));
                if (gener >= weight / (weight + 70))
                {
                    if (weight > 70)
                    {
                        Console.WriteLine("Блин, капец ты машина, даже всякие мма-бойцы с тобой не сравнятся!");
                        health = health - 15;
                        respect = respect + 25;
                        Console.Write($"Длина твоей норы: {lenth} \n");
                        Console.Write($"Твое здоровье: {health} \n");
                        Console.Write($"Твое уважение: {respect} \n");
                        Console.Write($"Твой вес: {weight} \n");
                        Console.WriteLine();
                    }
                    if (weight == 70)
                    {
                        Console.WriteLine("Мощный, побеждаешь себе равных, просто красавчик!");
                        health = health - 35;
                        respect = respect + 35;
                        Console.Write($"Длина твоей норы: {lenth} \n");
                        Console.Write($"Твое здоровье: {health} \n");
                        Console.Write($"Твое уважение: {respect} \n");
                        Console.Write($"Твой вес: {weight} \n");
                        Console.WriteLine();
                    }
                    if (weight < 70)
                    {
                        Console.WriteLine("Да что ты за машина черт возьми!?");
                        health = health - 70;
                        respect = respect + 50;
                        Console.Write($"Длина твоей норы: {lenth} \n");
                        Console.Write($"Твое здоровье: {health} \n");
                        Console.Write($"Твое уважение: {respect} \n");
                        Console.Write($"Твой вес: {weight} \n");
                        Console.WriteLine();
                    } 
                    
                }
                if (gener < weight / (weight + 70))
                {
                    if (weight > 70)
                    {
                        Console.WriteLine("Ну да...ты сильный...но и он неслабый...но ты все равно проиграл со своей силой, так что ты лох!!!");
                        health = health - 15;
                        respect = respect - 10;
                        Console.Write($"Длина твоей норы: {lenth} \n");
                        Console.Write($"Твое здоровье: {health} \n");
                        Console.Write($"Твое уважение: {respect} \n");
                        Console.Write($"Твой вес: {weight} \n");
                        Console.WriteLine();
                    }
                    if (weight == 70)
                    {
                        Console.WriteLine("Ну, тут либо да, либо нет, ничего удивительного, но ты все равно не сдавайся С:");
                        health = health - 35;
                        Console.Write($"Длина твоей норы: {lenth} \n");
                        Console.Write($"Твое здоровье: {health} \n");
                        Console.Write($"Твое уважение: {respect} \n");
                        Console.Write($"Твой вес: {weight} \n");
                        Console.WriteLine();
                    }
                    if (weight < 70)
                    {
                        Console.WriteLine("Да, ты проиграл, но это не отменяет того что ты чертова машина!!! ");
                        health = health - 70;
                        respect = respect + 10;
                        Console.Write($"Длина твоей норы: {lenth} \n");
                        Console.Write($"Твое здоровье: {health} \n");
                        Console.Write($"Твое уважение: {respect} \n");
                        Console.Write($"Твой вес: {weight} \n");
                        Console.WriteLine();
                    }

                }

            }
            cicle = cicle - 1;
        }
        if (change1 == 4)
        {
            Console.WriteLine("Мудрый выбор, уважаемо");
            lenth = lenth - 2;
            health = health + 20;
            respect = respect - 2;
            weight = weight - 5;
            Console.Write($"Длина твоей норы: {lenth} \n");
            Console.Write($"Твое здоровье: {health} \n");
            Console.Write($"Твое уважение: {respect} \n");
            Console.Write($"Твой вес: {weight} \n");
            Console.WriteLine();
            cicle = cicle - 1;
        }
        
            
        
    }
    while (cicle == 0)
    {
        Console.WriteLine("Наступила ночь");
        Console.WriteLine();
        Console.WriteLine("За ночь твои параметры чуток поменялись!");
        lenth = lenth - 2;
        health = health + 20;
        respect = respect - 2;
        weight = weight - 5;
        Console.Write($"Длина твоей норы: {lenth} \n");
        Console.Write($"Твое здоровье: {health} \n");
        Console.Write($"Твое уважение: {respect} \n");
        Console.Write($"Твой вес: {weight} \n");
        Console.WriteLine();
        cicle = cicle + 1;
    }
}
if ((lenth<=0) | (health<=0) | (weight <= 0))
{
    Console.WriteLine("Капец ты лох...ты проиграл!!");
}
if (respect >= 100)
{
    Console.WriteLine("Поздравляю! Ты самый уважаемый червь на грув-дыро-стрит!");
}