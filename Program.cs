using System;

class Lab1
{
    public int sumLastNums(int x)
    {
        int lastDigit = x % 10;
        x /= 10;
        int secondLastDigit = x % 10;

        return lastDigit + secondLastDigit;
    }

    public bool IsPositive(int x)
    {
        return x > 0;
    }

    public bool IsUpperCase(char x)
    {
        return x >= 'A' && x <= 'Z';
    }

    public bool IsDivisor(int a, int b)
    {
        return (a != 0 && b % a == 0) || (b != 0 && a % b == 0);
    }

    public static int LastNumSum(int a, int b)
    {
        // Получаем последнюю цифру каждого числа
        int lastDigitA = a % 10;
        int lastDigitB = b % 10;

        // Возвращаем сумму последних цифр
        return lastDigitA + lastDigitB;
    }

    public static int SumFiveNumbers(int[] numbers)
    {
        // Проверяем, что массив содержит ровно 5 чисел
        if (numbers.Length != 5) throw new ArgumentException("Массив должен содержать ровно 5 чисел.");

        int result = 0; // Инициализируем результат

        // Последовательное сложение
        for (int i = 0; i < numbers.Length; i++)
        {
            result = LastNumSum(result, numbers[i]);
            Console.WriteLine($"Результат после сложения: {result}");
        }

        return result;
    }

    public double SafeDiv(int x, int y)
    {
        if (y == 0)
        {
            return 0;
        }

        // Выполняем деление и возвращаем результат
        return (double)x / y;

    }

    public static string MakeDecision(int x, int y)
    {
        // Сравниваем числа и формируем строку с результатом
        if (x > y)
        {
            return $"{x} > {y}";
        }
        else if (x < y)
        {
            return $"{x} < {y}";
        }
        else
        {
            return $"{x} == {y}";
        }
    }

    public static bool Sum3(int x, int y, int z)
    {
        // Проверяем все возможные комбинации
        return (x + y == z) || (x + z == y) || (y + z == x);
    }

    public static string Age(int x)
    {
        string suffix;

        // Проверяем условия для выбора правильного слова
        if (x % 10 == 1 && x % 100 != 11)
        {
            suffix = "год";
        }
        else if (x % 10 >= 2 && x % 10 <= 4 && (x % 100 < 12 || x % 100 > 14))
        {
            suffix = "года";
        }
        else
        {
            suffix = "лет";
        }

        return $"{x} {suffix}";
    }

    public void PrintDays(string x)
    {
        // Переменная для хранения флага, найден ли день
        bool foundDay = true;

        // Используем switch для определения дня недели
        switch (x.ToLower())
        {
            case "понедельник":
                Console.WriteLine("понедельник");
                Console.WriteLine("вторник");
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "вторник":
                Console.WriteLine("вторник");
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "среда":
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "четверг":
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "пятница":
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "суббота":
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "воскресенье":
                Console.WriteLine("воскресенье");
                break;
            default:
                foundDay = false;
                break;
        }

        // Если день не найден, выводим сообщение
        if (!foundDay)
        {
            Console.WriteLine("это не день недели");
        }
    }

    public string ReverseListNums(int x)
    {
        // Проверяем, является ли x отрицательным
        if (x < 0)
        {
            return "Пожалуйста, введите положительное число.";
        }

        // Создаем массив для хранения чисел
        string result = "";

        // Цикл для добавления чисел к строке
        for (int i = x; i >= 0; i--)
        {
            result += i.ToString() + " ";
        }

        // Убираем последний пробел и возвращаем результат
        return result.Trim();
    }


    public int Pow(int x, int y)
    {
        // Переменная для хранения результата
        int result = 1;

        // Умножаем x на себя y раз
        for (int i = 0; i < y; i++)
        {
            result *= x;
        }

        return result;
    }

    public bool EqualNum(int x)
    {
        // Получаем последнюю цифру числа
        int lastDigit = x % 10;

        // Уменьшаем число, чтобы проверить остальные цифры
        x /= 10;

        // Проверяем все оставшиеся цифры
        while (x > 0)
        {
            // Если текущая цифра не равна последней, возвращаем false
            if (x % 10 != lastDigit)
            {
                return false;
            }
            // Уменьшаем число
            x /= 10;
        }

        // Если все цифры одинаковы, возвращаем true
        return true;
    }

    public void LeftTriangle(int x)
    {
        // Цикл для каждой строки от 1 до x
        for (int i = 1; i <= x; i++)
        {
            // Выводим i символов '*'
            Console.WriteLine(new string('*', i));
        }
    }

    public void GuessGame()
    {
        Random random = new Random();
        int secretNumber = random.Next(0, 10); // Генерация случайного числа от 0 до 9
        int attempts = 0;
        int userGuess = -1;

        Console.WriteLine("Введите число от 0 до 9:");

        // Цикл продолжается, пока пользователь не угадает число
        while (userGuess != secretNumber)
        {
            // Считываем ввод пользователя
            userGuess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (userGuess < 0 || userGuess > 9)
            {
                Console.WriteLine("Пожалуйста, введите число от 0 до 9:");
                attempts--; // Не учитываем попытку, если число вне диапазона
                continue;
            }

            if (userGuess == secretNumber)
            {
                Console.WriteLine("Вы угадали!");
            }
            else
            {
                Console.WriteLine("Вы не угадали, введите число от 0 до 9:");
            }
        }

        // Выводим количество попыток
        Console.WriteLine($"Вы отгадали число за {attempts} попытки(ок).");
    }

    public int FindLast(int[] arr, int x)
    {
        // Проходим по массиву в обратном порядке
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }
        return -1; // Если число не найдено, возвращаем -1
    }

    public int[] Add(int[] arr, int x, int pos)
    {
        // Проверка корректности позиции
        if (pos < 0 || pos > arr.Length)
        {
            throw new ArgumentOutOfRangeException("Позиция должна быть в пределах от 0 до длины массива.");
        }

        // Создаем новый массив с увеличенной длиной
        int[] newArr = new int[arr.Length + 1];

        // Копируем элементы до позиции pos
        for (int i = 0; i < pos; i++)
        {
            newArr[i] = arr[i];
        }

        // Вставляем элемент x на позицию pos
        newArr[pos] = x;

        // Копируем оставшиеся элементы
        for (int i = pos; i < arr.Length; i++)
        {
            newArr[i + 1] = arr[i];
        }

        return newArr; // Возвращаем новый массив
    }

    public void Reverse(int[] arr)
    {
        int left = 0; // Начальный индекс
        int right = arr.Length - 1; // Конечный индекс

        // Меняем элементы местами, пока не дойдем до середины
        while (left < right)
        {
            // Меняем местами элементы
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            // Сдвигаем индексы
            left++;
            right--;
        }
    }

    public int[] Concat(int[] arr1, int[] arr2)
    {
        // Создаем новый массив с длиной, равной сумме длин двух массивов
        int[] result = new int[arr1.Length + arr2.Length];

        // Копируем элементы первого массива в новый массив
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = arr1[i];
        }

        // Копируем элементы второго массива в новый массив
        for (int i = 0; i < arr2.Length; i++)
        {
            result[arr1.Length + i] = arr2[i];
        }

        return result; // Возвращаем новый объединенный массив
    }

    public int[] DeleteNegative(int[] arr)
    {
        // Используем список для динамического хранения положительных элементов
        List<int> positiveNumbers = new List<int>();

        // Проходим по всем элементам массива
        foreach (int num in arr)
        {
            // Если элемент не отрицательный, добавляем его в список
            if (num >= 0)
            {
                positiveNumbers.Add(num);
            }
        }

        // Преобразуем список в массив и возвращаем его
        return positiveNumbers.ToArray();
    }

    public static void Main(string[] args)
    {
        Lab1 lab = new Lab1();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Выберите программу:");
            Console.WriteLine("1. Сумма последних цифр двух чисел");
            Console.WriteLine("2. Проверка на положительное число");
            Console.WriteLine("3. Проверка на заглавную букву");
            Console.WriteLine("4. Проверка делимости");
            Console.WriteLine("5. Сложение пяти чисел");
            Console.WriteLine("6. Безопасное деление");
            Console.WriteLine("7. Сравнение двух чисел");
            Console.WriteLine("8. Проверка суммы трех чисел");
            Console.WriteLine("9. Формирование строки с возрастом");
            Console.WriteLine("10. Вывод дней недели");
            Console.WriteLine("11. Формирование строки с числами от x до 0");
            Console.WriteLine("12. Возведение в степень");
            Console.WriteLine("13. Проверка одинаковости цифр числа");
            Console.WriteLine("14. Вывод левого треугольника");
            Console.WriteLine("15. Игра 'Угадайка'");
            Console.WriteLine("16. Поиск последнего вхождения числа в массив");
            Console.WriteLine("17. Добавление элемента в массив");
            Console.WriteLine("18. Реверс массива");
            Console.WriteLine("19. Объединение двух массивов");
            Console.WriteLine("20. Удаление отрицательных элементов из массива");
            Console.WriteLine("0. Выход");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 20)
            {
                Console.WriteLine("Пожалуйста, введите число от 0 до 21.");
            }

            switch (choice)
            {
                case 1:
                    Lab1 program = new Lab1();

                    Console.Write("Введите число (больше 9): ");
                    string input = Console.ReadLine();

                    // Проверка на количество символов
                    if (input.Length < 2 || !int.TryParse(input, out int number))
                    {
                        Console.WriteLine("Ошибка: Введите число, содержащее не менее двух цифр.");
                        return;
                    }

                    int result = program.sumLastNums(number);
                    Console.WriteLine($"Сумма двух последних цифр: {result}");
                    break;
                case 2:
                    Console.WriteLine("Введите число:");
                    int positiveNum = GetIntInput();
                    Console.WriteLine(lab.IsPositive(positiveNum));
                    break;
                case 3:
                    Console.WriteLine("Введите символ:");
                    char upperCaseChar = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    Console.WriteLine(lab.IsUpperCase(upperCaseChar));
                    break;
                case 4:
                    Console.WriteLine("Введите два числа:");
                    int a = GetIntInput();
                    int b = GetIntInput();
                    Console.WriteLine(lab.IsDivisor(a, b));
                    break;
                case 5:
                    Console.WriteLine("Последовательно введите 5 чисел:");
                    int[] numbers = new int[5];
                    for (int i = 0; i < 5; i++)
                    {
                        numbers[i] = GetIntInput();
                    }
                    Console.WriteLine($"Сумма: {SumFiveNumbers(numbers)}");
                    break;
                case 6:
                    Console.WriteLine("Введите отдельно делимое и делитель:");
                    int dividend = GetIntInput();
                    int divisor = GetIntInput();
                    Console.WriteLine($"Результат деления: {lab.SafeDiv(dividend, divisor)}");
                    break;
                case 7:
                    Console.WriteLine("Введите первое и второе число:");
                    int x1 = GetIntInput();
                    int y1 = GetIntInput();
                    Console.WriteLine(MakeDecision(x1, y1));
                    break;
                case 8:
                    Console.WriteLine("Введите три числа:");
                    int x2 = GetIntInput();
                    int y2 = GetIntInput();
                    int z = GetIntInput();
                    Console.WriteLine(Sum3(x2, y2, z));
                    break;
                case 9:
                    Console.WriteLine("Введите возраст:");
                    int age = GetIntInput();
                    Console.WriteLine(Age(age));
                    break;
                case 10:
                    Console.WriteLine("Введите день недели:");
                    string day = Console.ReadLine();
                    lab.PrintDays(day);
                    break;
                case 11:
                    Console.WriteLine("Введите число:");
                    int x3 = GetIntInput();
                    Console.WriteLine(lab.ReverseListNums(x3));
                    break;
                case 12:
                    Console.WriteLine("Введите отдельно число и степень:");
                    int baseNum = GetIntInput();
                    int exponent = GetIntInput();
                    Console.WriteLine($"Результат: {lab.Pow(baseNum, exponent)}");
                    break;
                case 13:
                    Console.WriteLine("Введите число:");
                    int equalNum = GetIntInput();
                    Console.WriteLine(lab.EqualNum(equalNum));
                    break;
                case 14:
                    Console.WriteLine("Введите число:");
                    int triangleHeight = GetIntInput();
                    lab.LeftTriangle(triangleHeight);
                    break;
                case 15:
                    lab.GuessGame();
                    break;
                case 16:
                    Console.WriteLine("Введите элементы массива через пробел:");
                    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    Console.WriteLine("Введите число для поиска:");
                    int searchNum = GetIntInput();
                    int lastIndex = lab.FindLast(arr, searchNum);
                    Console.WriteLine(lastIndex != -1 ? $"Последнее вхождение: {lastIndex}" : "Число не найдено.");
                    break;

                case 17:
                    Console.WriteLine("Введите элементы массива через пробел:");
                    int[] originalArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    Console.WriteLine("Введите элемент для добавления:");
                    int elementToAdd = GetIntInput();
                    Console.WriteLine("Введите позицию для добавления:");
                    int position = GetIntInput();
                    int[] newArr = lab.Add(originalArr, elementToAdd, position);
                    Console.WriteLine($"Новый массив: [{string.Join(", ", newArr)}]");
                    break;

                case 18:
                    Console.WriteLine("Введите элементы массива через пробел:");
                    int[] reverseArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    lab.Reverse(reverseArr);
                    Console.WriteLine($"Реверсированный массив: [{string.Join(", ", reverseArr)}]");
                    break;

                case 19:
                    Console.WriteLine("Введите элементы первого массива через пробел:");
                    int[] firstArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                    Console.WriteLine("Введите элементы второго массива через пробел:");
                    int[] secondArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                    int[] concatenatedArr = lab.Concat(firstArr, secondArr);
                    Console.WriteLine($"Объединенный массив: [{string.Join(", ", concatenatedArr)}]");
                    break;

                case 20:
                    Console.WriteLine("Введите элементы массива через пробел:");
                    int[] deleteArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    int[] filteredArr = lab.DeleteNegative(deleteArr);
                    Console.WriteLine($"Массив без отрицательных элементов: [{string.Join(", ", filteredArr)}]");
                    break;

                case 0:
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Некорректный выбор.");
                    break;

            }
        }
    }

    // Метод для безопасного ввода целого числа
    private static int GetIntInput()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Пожалуйста, введите корректное целое число.");
        }
        return result;
    }
}
