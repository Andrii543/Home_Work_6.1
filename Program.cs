using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        bool valid = true;

        #region 1 Завдання Обчислення середнього заробітку

        //while (valid)
        //{
        //    Console.WriteLine("Введіть скільки працівник працюють");       
        //    if (!int.TryParse(Console.ReadLine(), out int userNrWorkersConsole) || userNrWorkersConsole == 0)
        //    {
        //        Console.WriteLine($"Ввели не коректну кількість працівників.Попробуйте ще раз");
        //        continue;
        //    }

        //    int sum = 0;

        //    for (int i = 1; i <= userNrWorkersConsole; i++)
        //    {
        //        Console.Write($"Зарплата {i} працівника: ");
        //        if (int.TryParse(Console.ReadLine(), out int price))
        //        {
        //            if (price < 0)
        //            {
        //                Console.WriteLine("Зарпалата не може бути 0 або відємною.Спробуйте ще раз");
        //                i--;
        //                continue;
        //            }

        //            sum += price;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Некорктний ввід.Попробуйте ще раз");
        //            i--;
        //        }

        //    }

        //    decimal result = (decimal)sum / userNrWorkersConsole;

        //    Console.WriteLine($"Середня сума {userNrWorkersConsole} працівників = {result:f2} грн");
        //}

        #endregion


        #region 2 Завдання Побудова графіку зірочками

        //Console.WriteLine("Введіть кількість рядків");

        //if(!int.TryParse(Console.ReadLine(), out int userInput))
        //{
        //    Console.WriteLine($"Ви ввели не коректну кілткість");
        //}

        //for(int i = 1; i <= userInput; i++)
        //{
        //    for(int j = 1; j <= i; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}

        #endregion


        #region 3 Завдання Генерація простих чисел

        //Console.Write("Введіть ліміт для простих числе: ");
        //int userInput = Convert.ToInt32(Console.ReadLine());

        //for (int i = 2; i <= userInput; i++)
        //{
        //    bool isPrime = true;
        //    for (int j = 2; j <= Math.Sqrt(i); j++)
        //    {
        //        if (i % j == 0)
        //        {
        //            isPrime = false;
        //            break;
        //        }
        //    }
        //    if (isPrime)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}



        #endregion

        #region 4 Завдання Перевірка паролю

        //while (valid)
        //{
        //    Console.WriteLine("Впишіть пароль. Пароль має містити 8 символів, одну цифру і спеціальний символ !,@,#,тощо");

        //    string userInput = Console.ReadLine();

        //    // Перевіряє довжину змінної яка не має бути менша ніж 8 
        //    if (userInput.Length < 8)
        //    {
        //        Console.WriteLine("Пароль має складатися із 8 символів");
        //        continue;
        //    }
        //    string ckecknumber = "[0123456789]";  /* [] квадратні душки дозволяють перевірити окремі символи в рядку без них 
        //                                         * це було б просте речення , а зними це виглядає так 0 , 1 , 2 і тд.
        //                                        */
        //    if (!Regex.IsMatch(userInput, ckecknumber)) // Regex.IsMatch він перевряє рядки по шаблону в данному випадку цифри
        //    {
        //        Console.WriteLine("Пароль має містити одну цифру");
        //        continue;
        //    }


        //    string specialChars = "[!@#$%^&*]"; /* [] квадратні душки дозволяють перевірити окремі символи в рядку без них 
        //                                         * це було б просте речення , а зними це виглядає так ! , @ , # і тд.
        //                                        */

        //    if (!Regex.IsMatch(userInput, specialChars)) 
        //    {
        //        Console.WriteLine("Пароль має містити спеціальні знаки");
        //        continue;
        //    }

        //    Console.WriteLine();

        //    Console.WriteLine($"Ваш пароль {userInput}");
        //    valid = false;


        //}

        #endregion

        #region 5 Завдання Генерація фібоначчівської послідовності

        //Console.WriteLine("Введіть кількість чисел Фібоначі ");
        //int userInput = Convert.ToInt32(Console.ReadLine());

        //if (userInput <= 0)
        //{
        //    Console.WriteLine("Число має бути більше 0");
        //    return;
        //}

        //int fibonachi = 0;

        //int fibonachiTwo = 1;

        //for (int i = 0; i < 7; i++)
        //{
        //    Console.WriteLine(fibonachi);

        //    int sum = fibonachi + fibonachiTwo;

        //    fibonachi = fibonachiTwo;

        //    fibonachiTwo = sum;


        //}
        #endregion

        #region 6 Завдання Калькулятор оплати праці за годину

        //while (valid)
        //{
        //    decimal result = 0;

        //    Console.Write("Скільки годин працює працівник на день: ");
        //    if (!int.TryParse(Console.ReadLine(), out int hoursPerDay) || hoursPerDay <= 0)
        //    {
        //        Console.WriteLine("Ввели не коректну кількість годин на день");
        //        continue;
        //    }

        //    Console.Write("Ставка на годину: ");
        //    if (!decimal.TryParse(Console.ReadLine(), out decimal perHour) || perHour < 0)
        //    {
        //        Console.WriteLine("Не коректна ставка на годину");
        //        continue;
        //    }

        //    result = (decimal)hoursPerDay * (decimal)perHour;
        //    Console.WriteLine($"Ставка на годину = {result:F2}");
        //    valid = false;

        //}




        #endregion

        #region 7 Завдання Генерація таблиці множення для конкретного числа
        //try
        //{
        //    Console.Write("Введіть число для множення: ");
        //    int userInput = Convert.ToInt32(Console.ReadLine());

        //    int result = 0;
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        result = userInput * i;
        //        Console.WriteLine($"{userInput} * {i} = {result}");
        //    }
        //}
        //catch (FormatException ex)
        //{
        //    Console.WriteLine($"Неправельний формат {ex}");
        //}

        #endregion

        #region 8 Завдання Перевірка на простоту
        Console.Write("Введіть просте число");
        int userInput = Convert.ToInt32(Console.ReadLine());

        bool isPrime = true;

        if (userInput < 2)
        {
            isPrime = false; // Числа менші за два не є простими : 0 , 1
        }
        else if (userInput == 2)
        {
            isPrime = true; // тільки два парне число є простим тому ми навіть не будем доходити до циклу 
        }
        else if (userInput % 2 == 0)
        {
            isPrime = false; // парні числа більше за 2 не є простим
        }
        else
        {
            for (int i = 3; i < Math.Sqrt(userInput); i++)
            {
                if (userInput % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine($"Число {userInput} є простим");
        }
        else
        {
            Console.WriteLine($"Число {userInput} не є простим");
        }



        #endregion
    }
}