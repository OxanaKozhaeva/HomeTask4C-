/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/
Console.WriteLine("Введите число");
int num=Convert.ToInt32(Console.ReadLine());
int a = Math.Abs(num);
/*string stringNum=Convert.ToString(a);
int SumDigits=0;
for (int i = 0; i < stringNum.Length; i++)
{
   SumDigits +=stringNum[i];
}
Console.WriteLine("Сумма цифр в числе - "+SumDigits);*/
int dig;//цифры, из которых состоит число
int SumDigits=0;
while(a>0)
{
    dig=a%10;
    SumDigits +=dig;
    a=a/10;
}
Console.WriteLine("Сумма цифр в числе - "+SumDigits);