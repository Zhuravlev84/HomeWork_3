/* Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

int N = ReadInt("Введите число от 1 и больше: ");
int a = 1;

if (N < 1)
{
    Console.Write("Введенное число некорректно");
}
else
        while(a <= N)
    {   
        Console.Write ($"{a*a*a} ");
        a++;
    }
  

int ReadInt (string message)
        {   
        Console.Write (message);
        return Convert.ToInt32(Console.ReadLine());
        }

