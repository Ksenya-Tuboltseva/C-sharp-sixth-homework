int [] array = new int [] {4, 60, 2, 15, 1, 9};
int sum = 0; // сумма произведений
for (int i = 0; i < array.Length / 2; i++)
{
    sum = sum + array[i] * array [array.Length - 1 - i];
    Console.WriteLine(sum);
}
Console.WriteLine(sum); //126