//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру обозначающую день недели: ");
int date = Convert.ToInt32(Console.ReadLine());

if(date == 6 || date == 7)
{
    Console.WriteLine("Выходной день");
}
else if (date < 1 || date > 7)
{
    Console.WriteLine("Вы ввели несуществующий день недели");
}
else
{
    Console.WriteLine("Будний день");
}