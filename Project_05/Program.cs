System.Console.WriteLine("Введите число: ");
int chislo = 0;
int sum = 0;
int count = int.Parse(Console.ReadLine()!);

while(chislo !=  count)
{
sum = chislo * chislo * chislo;
System.Console.WrsiteLine(sum);
chislo = chislo + 1;
sum = sum - sum;
}
sum = chislo * chislo * chislo;
System.Console.WriteLine(sum);
