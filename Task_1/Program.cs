/* Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */
int Number = ReadInt("Введите пятизначное число: ");

int a = (Number % 100000)/10000;
int b = (Number % 10000)/1000;
int c = (Number % 100)/10;
int d = Number % 10;

if (Number > 9999 && Number < 100000)
{
    if ( a == d && b == c)
    {
        Console.Write ("Число является палиндромом");
    }
    else
    {
        Console.Write ("Число не является палиндромом");
    }
}
else
{
    Console.Write ("Число не является пятизначным");
}


int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}