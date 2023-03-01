using System.Windows.Markup;
using static System.Net.Mime.MediaTypeNames;
int vibor, vibor_2;
int dlina_nory = 10; int health = 100; int respect = 20; int ves = 30; int lose_pts = 0; int den = 0;
Console.WriteLine("Добро пожаловать на Глоркс, существо. Ближайшее время покажет нам, кто ты: очередное звено в бесконечной цепи или нечто большее...");
Console.WriteLine($"Длина норы = {Convert.ToString(dlina_nory)}");
Console.WriteLine($"Здоровье = {Convert.ToString(health)}");
Console.WriteLine($"Уважение = {Convert.ToString(respect)}");
Console.WriteLine($"Вес = {Convert.ToString(ves)}");

do
{
    den++;
    Console.WriteLine($"День {den}");
    Console.WriteLine("1. Копать нору (+Длина норы, -Здоровье)");
    Console.WriteLine("2. Поесть травки (+Вес, +-Здоровье)");
    Console.WriteLine("3. Пойти подраться (+Уважение, -Здоровье)");
    Console.WriteLine("4. Проспать весь день (Длина норы: -2, Здоровье: +20, Уважение: -2, Вес: -5)");
    do
    {
        vibor = Convert.ToInt32(Console.ReadLine());
    } while (vibor > 4);
    if (vibor == 1)
    {
        Console.WriteLine("1. Интенсивно (Длина норы: +5, Здоровье: -30)");
        Console.WriteLine("2. Лениво (Длина норы: +2, Здоровье: -10)");
        do
        {
            vibor_2 = Convert.ToInt32(Console.ReadLine());
        } while (vibor_2 > 2);
        if (vibor_2 == 1)
        {
            Console.WriteLine("Ты довольно глубоко углубился в породу; попутно потеряв пару десятков зубов, которые острастут завтра");
            dlina_nory += 5; health -= 30;
        }
        else if (vibor_2 == 2)
        {
            Console.WriteLine("Лениво раскапывая землю, ты слегка расширил нору. Завтра ты этого уже не заметишь");
            dlina_nory += 2; health -= 10;
        }
    }
    else if (vibor == 2)
    {
        Console.WriteLine("1. Жухлой (Здоровье: +10, Вес: +15)");
        Console.WriteLine("2. Зелёной (Контроль по характеристике: Уважение)");
        do
        {
            vibor_2 = Convert.ToInt32(Console.ReadLine());
        } while (vibor_2 > 2);
        if (vibor_2 == 1)
        {
            Console.WriteLine("Отыскав никому не нужный клочок пожелтевшей травы, ты быстро и без аппетита набил ею брюхо (Здоровье: +10, Вес: +15)");
            health += 10; ves += 15;
        }
        if (vibor_2 == 2)
        {
            if (respect < 30)
            {
                Console.WriteLine("Огромный паук наступил на тебя, даже не заметив (Здоровье: -30)");
                health -= 30;
            }
            else
            {
                Console.WriteLine("Увидев тебя, остальные существа расступились, оставив тебе довольно красивый кусочек лужайки (Здововье: +30, Вес: +30)");
                health += 30; ves += 30;
            }
        }
    }
    else if (vibor == 3)
    {
        Console.WriteLine($"1. Со слабым противником (Вероятность победы: {ves * 100 / (ves + 30)}%)");
        Console.WriteLine($"2. Со средним противником (Вероятность победы: {ves * 100 / (ves + 50)}%)");
        Console.WriteLine($"3. С сильным противником (Вероятность победы: {ves * 100 / (ves + 70)}%)");
        do
        {
            vibor_2 = Convert.ToInt32(Console.ReadLine());
        } while (vibor_2 > 3);
        Random rnd = new Random();
        if (vibor_2 == 1)
        {
            int sluchai = rnd.Next(1, ves + 30);
            if (sluchai <= ves)
            {
                respect += 20 * (100 - (ves * 100 / (ves + 30))) / 100;
                Console.WriteLine($"Ты победил и получил {20 * (100 - (ves * 100 / (ves + 30))) / 100} уважения");
            }
            else
            {
                respect -= 20 * (100 - (ves * 100 / (ves + 30))) / 100;
                health -= 20 * (100 - (ves * 100 / (ves + 30))) / 100;
                Console.WriteLine($"Тебя победили и ты потерял {20 * (100 - (ves * 100 / (ves + 30))) / 100} уважения и  {20 * (100 - (ves * 100 / (ves + 30))) / 100}  здоровья");
            }
        }
        else if (vibor_2 == 2)
        {
            int sluchai = rnd.Next(1, ves + 50);
            if (sluchai <= ves)
            {
                respect += 40 * (100 - (ves * 100 / (ves + 50))) / 100;
                Console.WriteLine($"Ты победил и получил {40 * (100 - (ves * 100 / (ves + 50))) / 100} уважения");
            }
            else
            {
                respect -= 40 * (100 - (ves * 100 / (ves + 50))) / 100;
                health -= 40 * (100 - (ves * 100 / (ves + 50))) / 100;
                Console.WriteLine($"Тебя победили и ты потерял {40 * (100 - (ves * 100 / (ves + 50))) / 100} уважения и {40 * (100 - (ves * 100 / (ves + 50))) / 100} здоровья");
            }
        }
        else if (vibor_2 == 3)
        {
            int sluchai = rnd.Next(1, ves + 70);
            if (sluchai <= ves)
            {
                respect += 60 * (100 - (ves * 100 / (ves + 70))) / 100;
                Console.WriteLine($"Ты победил и получил {60 * (100 - (ves * 100 / (ves + 70))) / 100} уважения");
            }
            else
            {
                respect -= 60 * (100 - (ves * 100 / (ves + 70))) / 100;
                health -= 60 * (100 - (ves * 100 / (ves + 70))) / 100;
                Console.WriteLine($"Тебя победили и ты потерял {60 * (100 - (ves * 100 / (ves + 70))) / 100} уважения и {60 * (100 - (ves * 100 / (ves + 70))) / 100} здоровья");
            }
        }
    }
    if (vibor == 4)
    {
        Console.WriteLine("Твой сон ничего не потревожило");
        dlina_nory -= 2; health += 20; respect -= 2; ves -= 5;
    }
    Console.WriteLine("Ночь (Длина норы: -2, Здоровье: +20, Уважение: -2, Вес: -5)");
    dlina_nory -= 2; health += 20; respect -= 2; ves -= 5;
    Console.WriteLine($"Длина норы = {Convert.ToString(dlina_nory)}");
    Console.WriteLine($"Здоровье = {Convert.ToString(health)}");
    Console.WriteLine($"Уважение = {Convert.ToString(respect)}");
    Console.WriteLine($"Вес = {Convert.ToString(ves)}");
    if (dlina_nory <= 0 || health <= 0 || ves <= 0 || respect <= 0)
    {
        lose_pts++;
        break;
    }
} while (respect <= 100);

if (lose_pts == 1)
{
    Console.WriteLine("Жизнь на Глорксе оказалась слишком сложной для тебя, существо. Но, возможно, твои останки помогут другой жизни в её пути к вершине.");
}
else
{
    Console.WriteLine("Некоторое время назад обитатели Глоркса и представить не могли, что ты, существо, сможешь так быстро стать доминирующим на планете. Так держать!");
}