/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Введите число");
int Number = int.Parse(Console.ReadLine());

if (Number % 2 == 0)

    Console.WriteLine($"Число {Number} является четным");

else
    Console.WriteLine($"Число {Number} не является четным");