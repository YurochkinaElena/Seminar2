// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

//1 вариант
//Console.WriteLine("Введите трехзначное число: ");
//int numIn = Convert.ToInt32(Console.ReadLine());
//int numOut = (numIn % 100 - numIn % 10) / 10;
//Console.WriteLine(numOut);

//проверка на трехзначность
//if (numIn < 100 || numIn >= 1000)
//{
//   Console.WriteLine("Число не трехзначное");
//}
//else
//{
//  Console.WriteLine(numOut);
//}

//2й вариант
Console.WriteLine("Введите трехзначное число: ");
int numIn = Convert.ToInt32(Console.ReadLine());
int numOut = numIn / 10 % 10;
Console.Write("Вторая цифра: ");
Console.WriteLine(numOut);