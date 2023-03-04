namespace text_quest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool game_is_work = false, fight_flag = false;
            int burrow_length = 10, health = 100, respect = 20, weight = 30, enemy_weight = 0;
            string selected_number, temp;
            Console.WriteLine("Управление осуществляется в консоли при помощи цифр.\nЦель игры – добиться уважения больше 100 и не дать основным параметрам упасть до нуля.\nВведите номер действия и нажмите Enter.");
            Console.WriteLine("Начать игру?\n1. Да\n2. Нет");
            if (Console.ReadLine() == "1") game_is_work = true;
            while (game_is_work)
            {
                print_stats(burrow_length, health, respect, weight);
                Console.WriteLine("\nВыберите действие\n1. Копать нору.\n2. Поесть травку.\n3. Пойти подраться.\n4. Проспать весь день.");
                switch (selected_number = Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("\n1. Интенсивно.\n2. Лениво.");
                        temp = Console.ReadLine();
                        if (temp == "1")
                        {
                            burrow_length += 5;
                            health -= 30;
                        } 
                        else if (temp == "2")
                        {
                            burrow_length += 2;
                            health -= 10;
                        }
                        break;
                    case "2":
                        Console.WriteLine("\n1. Жухлой.\n2. Зеленой.");
                        temp = Console.ReadLine();
                        if (temp == "1")
                        {
                            health += 10;
                            weight += 15;
                        }
                        else if (temp == "2")
                        {
                            if (respect < 30) health -= 30;
                            else
                            {
                                health += 30;
                                weight += 30;
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("\n1. Со слабым существом.\n2. Со средним существом. \n3. С сильным существом.");
                        temp = Console.ReadLine(); 
                        if (temp == "1")
                        {
                            enemy_weight = 30;
                            fight_flag = true;
                        }
                        else if (temp == "2")
                        {
                            enemy_weight = 50;
                            fight_flag = true;
                        }
                        else if (temp == "3")
                        {
                            enemy_weight = 70;
                            fight_flag = true;
                        }
                        if (rnd.Next(enemy_weight + weight) < weight && fight_flag)
                        {
                            if (weight - enemy_weight == 0)
                            {
                                respect += 5;
                                health -= 1;
                            }
                            else if (enemy_weight - weight >= 30)
                            {
                                respect += 20;
                                health -= 15;
                            }
                            else if (enemy_weight - weight >= 15 && enemy_weight - weight < 30)
                            {
                                respect += 15;
                                health -= 10;
                            }
                            else if (enemy_weight -  weight > 0 && enemy_weight - weight < 15)
                            {
                                respect += 15;
                                health -= 5;
                            }
                            else if (enemy_weight - weight < 0)
                            {
                                respect += 5;
                            }
                            fight_flag = false;
                        }
                        else
                        {
                            if (enemy_weight - weight == 0)
                            {
                                respect -= 10;
                                health -= 10;
                            }
                            else if (enemy_weight - weight > 0)
                            {
                                health -= 20;
                                respect -= 5;
                            }
                            else if(enemy_weight - weight < 0)
                            {
                                health -= 5;
                                respect -= 20;
                            }
                            fight_flag = false;
                        }    
                        break;
                    case "4":
                        burrow_length -= 2;
                        health += 20;
                        respect -= 2;
                        weight -= 5;
                        break;
                    default:
                        Console.WriteLine("Введите корректный вариант");
                        break;
                }

                Console.WriteLine("\nНаступает ночь.");
                burrow_length -= 2;
                health += 20;
                respect -= 2;
                weight -= 5;

                if (burrow_length <= 0 || health <= 0 || respect <= 0 || weight <= 0)
                {
                    Console.WriteLine("Вы проиграли.\nНачать игру заного?\n1. Да\n2. Нет");
                    if (Console.ReadLine() == "1")
                    {
                        burrow_length = 10;
                        health = 100;
                        respect = 20;
                        weight = 30;
                    }
                    else game_is_work = false;
                }

                if (respect > 100)
                {
                    Console.WriteLine("Вы выиграли.\nНачать игру заного?\n1. Да\n2. Нет");
                    if (Console.ReadLine() == "1")
                    {
                        burrow_length = 10;
                        health = 100;
                        respect = 20;
                        weight = 30;
                    }
                    else game_is_work = false;
                }
            }

        }



        static void print_stats(int burrow_length, int health, int respect, int weight)
        {
            Console.WriteLine("\nДлина норы\t" + burrow_length + "\nЗдоровье\t" + health + "\nУважение\t" + respect + "\nВес\t\t" + weight);
        }
    }
}