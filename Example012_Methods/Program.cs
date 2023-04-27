// // Первая группа методов. Не принимает никаких аргументов и ничего не возвращаютю

// void Method1()
// {
//     Console.WriteLine("Автор …");
// }
// // Method1(); // вызов функции



// // Вторая группа методов. Принимает какие-то аргументы, но ничего не возвращают.


// void Metod2(string msg) //где void ключевое слово, дальше идентификатор, в скобках указаны какие-то аргументы.
// {
//     Console.WriteLine(msg); // оператор, в скобках указан принятый аргумент.
// }
// Metod2(“Текст сообщения”); // где Metod2 является идентификатором, а в скобках указан текст, выводимый в консоли.

// // Именованные аргументы

// void Metod21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg); // где переменная count отображает на экране определённое количество сообщений msg.
//         i++;
//     }
// }
// // Metod21("Текст", 4);
// // Metod21(msg: "Текст", count: 4);

// Metod21(count: 4, msg: "Текст");



// // Третья группа методов. Может что-то возвращать, но не принимает никаких аргументов. 

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int Year = Method3();
// Console.WriteLine(Year);



// Четвёртая группа методов. Что-то принимает (аргументы, данные). И что-то возвращает для дальнейшей работы.

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "p");
// Console.WriteLine(res);

// То же самое с циклом for.

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "p");
// Console.WriteLine(res);

// Таблица умножения

// for (int i = 2; i <= 10; i++)
// {
// for (int j = 2; j <= 10; j++)
// {
// Console.WriteLine($"{i} * {j} = {i * j}");
// }
// Console.WriteLine();
// }


// Задача. Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
// заменить большими «К», а маленькие «с» заменить на большие «С».

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
// + "ежели бы вас послали вместо нашего милого Винценгероде,"
// + "вы бы взяли приступом согласие прусского короля."
// + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = “qwerty”
// // 012345

// // s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
// string result = String.Empty;
// int length = text.Length;
// for (int i = 0; i < length; i++)
// {
// if(text[i] == oldValue) result = result + $"{newValue}";
// else result = result + $"{text[i]}";
// }
// return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);

// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);


//  Написать метод, который будет упорядочивать наш массив от меньшего числа к большему.

// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}");
//     }
//     Console.WriteLine();
// }
// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition])
//             {
//                 minPosition = j;
//             }
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }
// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);


// Написать метод, который будет упорядочивать наш массив от большего числа к меньшему.

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);