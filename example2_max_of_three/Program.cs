// Вводим три числа, на выходе увидим какое из них максимальное
Console.WriteLine("Введите число а");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число с");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b)
    {
        max = b;
    }
if (max < c)
    {
    max = c;
    }
Console.WriteLine("Число " + max + " является максимальным числом");
  