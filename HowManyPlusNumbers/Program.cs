Console.WriteLine("Введите значение");
int M1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение");
int M2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение");
int M3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение");
int M4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение");
int M5 = Convert.ToInt32(Console.ReadLine());
int count = 0; //счетчик положительных чисел
if (M1 > 0)
{
    count = count + 1;
}
if (M2 > 0)
{
    count = count + 1;
}
if (M3 > 0)
{
    count = count + 1;
}
if (M4 > 0)
{
    count = count + 1;
}
if (M5 > 0)
{
    count = count + 1;
}
Console.WriteLine(count);