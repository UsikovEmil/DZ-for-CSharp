﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Clear();

string? a = ""; //  string? Стринг может быть Null который необходимо обработать
int count = 0;
Console.WriteLine("Введите числа поочерёдно: ");
while (a != "stop")
{
    a = Console.ReadLine();
    if (a == "stop") 
    {
        Console.WriteLine($"Количесвто чисел > 0 = {count}");
        break;
    }
    if (Convert.ToInt32(a) > 0) count += 1;
}






