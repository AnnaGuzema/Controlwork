 Console.WriteLine("Введите строки через запятую:");
        string input = Console.ReadLine();

        // Разделяем введенную строку на подстроки по запятой
        string[] originalArray = input.Split(',');

        // Формируем новый массив из строк, длина которых меньше или равна 3 символам
        string[] newArray = FilterArrayByLength(originalArray, 3);

        // Выводим исходный и новый массивы
        Console.WriteLine("\nИсходный массив:");
        PrintArray(originalArray);



    static string[] FilterArrayByLength(string[] originalArray, int maxLength)
    {
        int count = 0;

        // Подсчитываем количество строк, удовлетворяющих условию
        for (int i = 0; i < originalArray.Length; i++)
        {
            if (originalArray[i].Length <= maxLength)
            {
                count++;
            }
        }

        // Создаем новый массив с учетом подсчитанного количества строк
        string[] newArray = new string[count];
        int newIndex = 0;

        // Заполняем новый массив строками, удовлетворяющими условию
        for (int i = 0; i < originalArray.Length; i++)
        {
            if (originalArray[i].Length <= maxLength)
            {
                newArray[newIndex] = originalArray[i];
                newIndex++;
            }
        }

        return newArray;
    }

    static void PrintArray(string[] array)
    {
        foreach (string element in array)
        {
            Console.WriteLine(element);
        }
    }  

Console.WriteLine("Новый массив (длина строки <= 3 символов):");
PrintArray(newArray);