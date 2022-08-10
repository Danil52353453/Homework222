//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if(n<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if(n>100)
{
    while(n>=1000)
    {
        n/=10;
    }
    int b = n%10;
    Console.WriteLine(b);
}
