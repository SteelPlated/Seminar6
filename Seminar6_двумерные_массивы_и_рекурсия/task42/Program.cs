/*Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10*/

Console.WriteLine("Введите число для перевода");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите основание системы счисления");
int baseNum = int.Parse(Console.ReadLine());

/*int digit10 = 1;
int result = 0;

while (num != 0)
{
    result = result + num % baseNum * digit10;
    num = num / baseNum;
    digit10 *= 10;
}
Console.WriteLine(result);*/

//рекурсия
void DecToOther(int n, int baseN)
{
    if (n == 0) return;
    DecToOther(n / baseN, baseN);
    Console.Write(n % baseN);
}
DecToOther(num, baseNum);
