using System;

namespace CSLight
{
   internal class Program
   {
      static void Main(string[] args)
      {
         int burrowLenght = 10;
         int userHealth = 100;
         int userRespect = 20;
         int userWeight = 30;

         int userChoice;

         int enemyWeekWeight = 30;
         int enemyNormalWeight = 50;
         int enemyStrongWeight = 70;

         Console.WriteLine("Игра - кролик\n");
         while (userHealth > 0 && userWeight > 0 && userRespect > 0 && burrowLenght > 0)
         {
            Console.WriteLine($"Длина норы {burrowLenght}");
            Console.WriteLine($"Здоровье {userHealth}");
            Console.WriteLine($"Уважение {userRespect}");
            Console.WriteLine($"Вес {userWeight}\n");

            if (userRespect >= 100)
            {
               Console.WriteLine("Вы выйграли");
               break;
            }


            Console.WriteLine("1 - Копать нору. 2 - Поесть травку. 3 - Драться. 4 - Спать.\n");

            switch (userChoice = Convert.ToInt32(Console.ReadLine()))
            {
               case 1:
                  Console.WriteLine("1 - Копать интенсивно. 2 - Копать лениво.");
                  Console.Write("Что выберешь? ");
                  int howToDig = Convert.ToInt32(Console.ReadLine());
                  if (howToDig == 1)
                  {
                     burrowLenght += 5;
                     userHealth -= 30;
                  }
                  else
                  {
                     burrowLenght += 2;
                     userHealth -= 10;
                  }
                  Console.WriteLine($"Длина норы {burrowLenght}");
                  Console.WriteLine($"Здоровье {userHealth}");
                  Console.WriteLine($"Уважение {userRespect}");
                  Console.WriteLine($"Вес {userWeight}\n");
                  break;
               case 2:
                  Console.WriteLine("1 - Есть жухлую травку. 2 - Есть зеленую травку.");
                  Console.Write("Что выберешь? ");
                  int whatToEat = Convert.ToInt32(Console.ReadLine());
                  if (whatToEat == 1)
                  {
                     userHealth += 10;
                     userWeight += 15;
                  }
                  else
                  {
                     if (userRespect < 30)
                     {
                        userHealth -= 30;
                     }
                     else
                     {
                        userHealth += 30;
                        userWeight += 30;
                     }
                  }
                  Console.WriteLine($"Длина норы {burrowLenght}");
                  Console.WriteLine($"Здоровье {userHealth}");
                  Console.WriteLine($"Уважение {userRespect}");
                  Console.WriteLine($"Вес {userWeight}\n");
                  break;

               case 3:
                  Console.WriteLine("Борьба!");
                  Console.WriteLine("С каким по силе существом пойдешь драться?");
                  Console.Write("1 - Дрищ. 2 - Середнячок. 3 - Жестка! ");
                  int whoToFight = Convert.ToInt32(Console.ReadLine());
                  Random rand = new Random();
                  if (whoToFight == 1)
                  {
                     Console.WriteLine("Я бью женщин и детей, потому что я сильней");
                     int chance = rand.Next(1, enemyWeekWeight + userWeight);
                     Console.WriteLine(chance);
                     Console.ReadLine();
                     if (chance > userWeight)
                     {
                        Console.WriteLine("Проиграть такому существу...");
                        userHealth -= enemyWeekWeight * 2;
                        userRespect -= enemyWeekWeight;
                     }
                     else
                     {
                        Console.WriteLine("Не удивлен победе...");
                        userHealth -= enemyWeekWeight / 2;
                        userRespect += enemyWeekWeight;

                     }
                  }
                  else if (whoToFight == 2)
                  {
                     Console.WriteLine("Борьба на равных.");
                     int chance = rand.Next(1, enemyNormalWeight + userWeight);
                     if (chance > userWeight)
                     {
                        Console.WriteLine("Ты проиграл.");
                        userHealth -= enemyWeekWeight;
                        userRespect -= enemyWeekWeight;
                     }
                     else
                     {
                        Console.WriteLine("Ты выйграл");
                        userHealth -= enemyWeekWeight / 2;
                        userRespect += enemyWeekWeight;
                     }
                  }
                  else
                  {
                     Console.WriteLine("Бро, ты не Гатс...");
                     int chance = rand.Next(1, enemyStrongWeight + userWeight);
                     if (chance > userWeight)
                     {
                        Console.WriteLine("Не прыгнешь выше головы.");
                        userHealth -= enemyWeekWeight;
                        userRespect -= enemyWeekWeight;
                     }
                     else
                     {
                        Console.WriteLine("Что ты такое...");
                        userHealth -= enemyWeekWeight / 3;
                        userRespect += enemyWeekWeight;
                     }
                  }
                  Console.WriteLine($"Длина норы {burrowLenght}");
                  Console.WriteLine($"Здоровье {userHealth}");
                  Console.WriteLine($"Уважение {userRespect}");
                  Console.WriteLine($"Вес {userWeight}\n");
                  break;

               case 4:
                  Console.WriteLine("Баиньки.");
                  burrowLenght -= 2;
                  userHealth += 20;
                  userRespect -= 2;
                  userWeight -= 5;
                  Console.WriteLine($"Длина норы {burrowLenght}");
                  Console.WriteLine($"Здоровье {userHealth}");
                  Console.WriteLine($"Уважение {userRespect}");
                  Console.WriteLine($"Вес {userWeight}\n");
                  break;
            }

            Console.ReadLine();
            Console.WriteLine("Наступила ночь");
            burrowLenght -= 2;
            userHealth += 20;
            userRespect -= 2;
            userWeight -= 5;
            Console.WriteLine($"Длина норы {burrowLenght}");
            Console.WriteLine($"Здоровье {userHealth}");
            Console.WriteLine($"Уважение {userRespect}");
            Console.WriteLine($"Вес {userWeight}\n");


            if (userHealth <= 0 || userWeight <= 0 || userRespect <= 0 || burrowLenght <= 0)
            {
               Console.WriteLine("Вы проиграли");
            }
            Console.ReadLine();
            Console.Clear();

         }
      }
   }
}


