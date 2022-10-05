/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Введите первое число");
string firstNum = Console.ReadLine();

Console.WriteLine("Введите второе число");
string secondNum = Console.ReadLine();

Console.WriteLine("Введите третье число");
string thirdNum = Console.ReadLine();

int firstNumber = int.Parse(firstNum);
int secondNumber = int.Parse(secondNum);
int thirdNumber = int.Parse(thirdNum);
int maxNumber = firstNumber;
if (firstNumber > secondNumber && firstNumber > thirdNumber)

maxNumber =firstNumber;

else if (secondNumber > firstNumber && secondNumber > thirdNumber)

maxNumber = secondNumber;

else

maxNumber = thirdNumber;

Console.WriteLine($"Максимальное из трех значений является {maxNumber}");

