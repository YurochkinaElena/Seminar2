// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе 
//число кратно первому. Если число 2 не кратно числу 1, программа выводит остаток от деления.
//34,5 -> не кратно, остаток от деления 4
//16,4 -> кратно

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 % num2 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Остаток от деления {num1 % num2}");
}