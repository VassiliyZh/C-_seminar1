// Вводим два числа, на выходе увидим какой из них мин, какой макс
Console.WriteLine("Введите число а");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    {
        Console.WriteLine("a является max, b является min числом");
    }
else
    {
        Console.WriteLine("a является min, b является max числом");
    }
