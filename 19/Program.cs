//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int x;
int sum = 0;
int numX;
Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
for (numX = num; num != 0; num = num / 10)
{
    x = num % 10;
    sum = sum * 10 + x;
}
if (numX == sum)
{
    Console.Write($"{numX} Это палиндром");
}
else
{
    Console.Write($"{numX} Не палиндром");
}