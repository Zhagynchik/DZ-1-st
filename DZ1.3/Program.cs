/*Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console.Clear();

Console.WriteLine("Введите число");
string number1Str = Console.ReadLine();
int number1 = Convert.ToInt32(number1Str);

if (number1 % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}


