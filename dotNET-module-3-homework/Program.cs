using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        zadacha_1(array);

        int[] array2 = { 2, 4, 6, 8, 10 };
        zadacha_2(array2);

        int[] array3 = { 1, 2, 3, 4, 5 };
        zadacha_3(array3, 2);

        zadacha_4();

        int[] array5 = { 1, 2, 3, 4, 5 };
        zadacha_5(array5, 2, 99);

        int[] array6 = { 1, 2, 3, 2, 4, 5, 4, 6, 7 };
        zadacha_6(array6);

        zadacha_7();

        zadacha_8();

        string text3 = "Это строка со словами, которые начинаются и заканчиваются одной буквой.";
        zadacha_9(text3);

        int[,] matrix1 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        zadacha_10(matrix1);

        int[,] matrix2 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        zadacha_11(matrix2);

        int[,] matrix3 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        zadacha_12(matrix3);

        zadacha_13();

        Console.WriteLine("Задача №14");
        string text4 = ReadText();
        zadacha_14(text4);

        zadacha_15();

        Console.ReadLine();
    }

    static void zadacha_1(int[] array)
    {
        Console.WriteLine("Задача №1");

        Console.WriteLine("Массив целых чисел:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void zadacha_2(int[] array)
    {
        Console.WriteLine("Задача №2");

        int maxEven = int.MinValue;
        int maxEvenIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0 && array[i] > maxEven)
            {
                maxEven = array[i];
                maxEvenIndex = i;
            }
        }

        if (maxEvenIndex != -1)
        {
            Console.WriteLine($"Индекс максимального четного значения: {maxEvenIndex}");
        }
        else
        {
            Console.WriteLine("В массиве нет четных чисел.");
        }
    }

    static void zadacha_3(int[] array, int index)
    {
        Console.WriteLine("Задача №3");

        if (index >= 0 && index < array.Length)
        {
            int[] newArray = new int[array.Length - 1];
            int newIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i != index)
                {
                    newArray[newIndex] = array[i];
                    newIndex++;
                }
            }

            Console.WriteLine("Массив после удаления элемента:");
            foreach (int num in newArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Индекс выходит за границы массива.");
        }
    }

    static void zadacha_4()
    {
        Console.WriteLine("Задача №4");

        Console.WriteLine("Введите номер трамвайного билета (6-значное число):");
        string ticketNumber = Console.ReadLine();

        if (ticketNumber.Length == 6)
        {
            int sumFirstHalf = 0;
            int sumSecondHalf = 0;

            for (int i = 0; i < 6; i++)
            {
                int digit = int.Parse(ticketNumber[i].ToString());

                if (i < 3)
                {
                    sumFirstHalf += digit;
                }
                else
                {
                    sumSecondHalf += digit;
                }
            }

            if (sumFirstHalf == sumSecondHalf)
            {
                Console.WriteLine("Этот билет счастливый!");
            }
            else
            {
                Console.WriteLine("Этот билет не счастливый.");
            }
        }
        else
        {
            Console.WriteLine("Введите корректный номер трамвайного билета (6-значное число).");
        }
    }

    static void zadacha_5(int[] array, int index, int value)
    {
        Console.WriteLine("Задача №5");

        if (index >= 0 && index <= array.Length)
        {
            int[] newArray = new int[array.Length + 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < index)
                {
                    newArray[i] = array[i];
                }
                else if (i == index)
                {
                    newArray[i] = value;
                }
                else
                {
                    newArray[i] = array[i - 1];
                }
            }

            Console.WriteLine("Массив после вставки элемента:");
            foreach (int num in newArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Индекс выходит за границы массива.");
        }
    }

    static void zadacha_6(int[] array)
    {
        Console.WriteLine("Задача №6");

        var grouped = array.GroupBy(num => num);
        int[] newArray = array.Where(num => grouped.Count(group => group.Key == num) != 2).ToArray();

        Console.WriteLine("Массив после удаления элементов, встречающихся дважды:");
        foreach (int num in newArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void zadacha_7()
    {
        Console.WriteLine("Задача №7");

        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();
        char[] charArray = input.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsLower(charArray[i]))
            {
                charArray[i] = char.ToUpper(charArray[i]);
            }
            else if (char.IsUpper(charArray[i]))
            {
                charArray[i] = char.ToLower(charArray[i]);
            }
        }

        string result = new string(charArray);
        Console.WriteLine($"Результат конвертации: {result}");
    }

    static void zadacha_8()
    {
        Console.WriteLine("Задача №8");

        Console.WriteLine("Введите целое число:");
        int number = int.Parse(Console.ReadLine());
        string numberString = number.ToString();
        char[] charArray = numberString.ToCharArray();
        Array.Reverse(charArray);
        string reversedNumberString = new string(charArray);
        int reversedNumber = int.Parse(reversedNumberString);

        Console.WriteLine($"Число, прочитанное справа налево: {reversedNumber}");
    }

    static void zadacha_9(string text)
    {
        Console.WriteLine("Задача №9");

        string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        string result = "";

        foreach (string word in words)
        {
            if (word.Length >= 2 && word[0] == word[word.Length - 1])
            {
                result += "[" + word + "] ";
            }
            else
            {
                result += word + " ";
            }
        }

        Console.WriteLine("Строка с выделенными словами:");
        Console.WriteLine(result);
    }

    static void zadacha_10(int[,] matrix)
    {
        Console.WriteLine("Задача №10");

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            if (matrix[i, i] % 2 == 0)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        Console.WriteLine("Массив после обнуления элементов строк с четными элементами на главной диагонали:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void zadacha_11(int[,] matrix)
    {
        Console.WriteLine("Задача №11");

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < cols; i++)
        {
            if (matrix[i, i] % 2 == 0)
            {
                for (int j = 0; j < rows; j++)
                {
                    matrix[j, i] = 0;
                }
            }
        }

        Console.WriteLine("Массив после обнуления элементов столбцов с четными элементами на главной диагонали:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void zadacha_12(int[,] matrix)
    {
        Console.WriteLine("Задача №12");

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[] columnCounts = new int[cols];

        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                for (int k = j + 1; k < rows; k++)
                {
                    if (matrix[j, i] == matrix[k, i])
                    {
                        columnCounts[i]++;
                        break;
                    }
                }
            }
        }

        for (int i = cols - 1; i >= 0; i--)
        {
            if (columnCounts[i] >= 2)
            {
                for (int j = 0; j < rows; j++)
                {
                    for (int k = i; k < cols - 1; k++)
                    {
                        matrix[j, k] = matrix[j, k + 1];
                    }
                }
                cols--;
            }
        }

        Console.WriteLine("Массив после удаления столбцов с двумя одинаковыми элементами:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void zadacha_13()
    {
        Console.WriteLine("Задача №13");

        int[,] array = new int[5, 5];
        Random rnd = new Random();

        // Заполнение массива случайными числами
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = rnd.Next(-100, 101);
            }
        }

        int min = array[0, 0];
        int max = array[0, 0];

        // Находим минимальный и максимальный элементы
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                }
                if (array[i, j] > max)
                {
                    max = array[i, j];
                }
            }
        }

        int sum = 0;
        bool betweenMinMax = false;

        // Вычисляем сумму элементов между минимальным и максимальным элементами
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (array[i, j] == min)
                {
                    betweenMinMax = !betweenMinMax;
                }
                else if (array[i, j] == max)
                {
                    betweenMinMax = !betweenMinMax;
                }
                else if (betweenMinMax)
                {
                    sum += array[i, j];
                }
            }
        }

        Console.WriteLine($"Минимальный элемент: {min}");
        Console.WriteLine($"Максимальный элемент: {max}");
        Console.WriteLine($"Сумма элементов между минимальным и максимальным элементами: {sum}");
    }

    static string ReadText()
    {
        Console.WriteLine("Введите текст (для завершения введите точку '.'): ");
        string text = "";
        string line;
        while ((line = Console.ReadLine()) != null && line != ".")
        {
            text += line + " ";
        }
        return text.Trim();
    }

    static void zadacha_14(string text)
    {
        string result = text.Replace("/", "").Replace("\\", "");
        Console.WriteLine("Строка после удаления знаков '/' и '\\':");
        Console.WriteLine(result);
    }

    static void zadacha_15()
    {
        Console.WriteLine("Задача №15");

        string word = "класс";
        string replacedWord = ReplaceDuplicateLetters(word, '1', 2);

        Console.WriteLine($"Исходное слово: {word}");
        Console.WriteLine($"Результат замены: {replacedWord}");
    }

    static string ReplaceDuplicateLetters(string word, char replacement, int maxReplacements)
    {
        char[] charArray = word.ToCharArray();

        for (int i = 0; i < charArray.Length - 1; i++)
        {
            if (charArray[i] == charArray[i + 1])
            {
                charArray[i + 1] = replacement;
                maxReplacements--;

                if (maxReplacements == 0)
                {
                    break;
                }
            }
        }

        return new string(charArray);
    }
}
