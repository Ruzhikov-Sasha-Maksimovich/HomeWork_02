System.Console.WriteLine("Введите число: ");
int chislo = int.Parse(Console.ReadLine()!);
int i1 = chislo % 100000 / 10000;
int i2 = chislo % 10000 / 1000;
int i4 = chislo % 100 / 10;
int i5 = chislo % 10;

if (i1 == i5 && i2 == i4)
{
    System.Console.WriteLine("Это палиндром!");
}
else
{
    System.Console.WriteLine("Это не палиндром!");
}