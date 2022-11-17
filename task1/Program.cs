// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру из этого числа
//456->46
//782->72
//918->98

int randomNum = new Random().Next(100, 1000); //рандомное число
Console.WriteLine(randomNum);
//238
//28
//1й способ
int num = (randomNum / 100) * 10 + randomNum % 10;
Console.WriteLine(num);

//2й способ - строчный
string stringNum = randomNum.ToString();
Console.WriteLine($"{stringNum[0]}{stringNum[2]}");