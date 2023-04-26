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

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "p");
Console.WriteLine(res);

