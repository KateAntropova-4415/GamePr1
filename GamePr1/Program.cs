using System;

namespace GamePr1
{
    class Game
    {
        static void Main(string[] args)
        {
            int sum = 10;
            try
            {
                Console.WriteLine("Ваш счёт на текущий момент 10 баллов");
                GameAct(ref sum);
                While(ref sum);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e.Message);
            }

        }

        private static void While(ref int sum)
        {
            int yesorno;
            while (sum > 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Ваш счет:" + sum);
                Console.WriteLine("Продолжить игру или забрать текущий выигрыш?");
                Console.WriteLine("Любой номер - да");
                Console.WriteLine("0 - нет");
                Console.WriteLine("Любая цифра или 0? Ваш выбор:");
                yesorno = int.Parse(Console.ReadLine());
                if (yesorno == 0)
                    break;
                Console.WriteLine("\n");
                GameAct(ref sum);
            }
            Console.WriteLine("Игра окончена! Ваш счёт " + sum);
        }

        private static void GameAct(ref int sum)
        {
            int rate;
            int choice;
            int answer;

            Console.WriteLine("1. Нечетное число");
            Console.WriteLine("2. Четное число");
            Console.WriteLine("1 или 2? Ваш выбор:");
            choice = int.Parse(Console.ReadLine());
            Random New = new Random();
            answer = New.Next(2);
            Console.WriteLine("Ваша ставка:");
            rate = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            if (rate <= 0)
            {
                Console.WriteLine("Ставка не сделана.");
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        if (answer % 2 == 0)
                        {
                            sum -= rate;
                            Console.WriteLine("Не угадали.");
                        }
                        else
                        {
                            sum += rate;
                            Console.WriteLine("Угадали!");
                        }
                        break;
                    case 2:
                        if (answer % 2 == 0)
                        {
                            sum += rate;
                            Console.WriteLine("Угадали!");
                        }
                        else
                        {
                            sum -= rate;
                            Console.WriteLine("Не угадали.");
                        }
                        break;
                    default: Console.WriteLine("Выбор не сделан."); break;
                }
            }
        }
    }
}
