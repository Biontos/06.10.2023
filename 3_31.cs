// Задание 3 стр 31
Console.Write("Введите количество часов : ");
int n = int.Parse(Console.ReadLine());
int ameba = 1;
for (int hours = 3; hours <= n; hours += 3)
{
    ameba *= 2;
}
Console.WriteLine($"Через {n} часов будет {ameba} амеб");