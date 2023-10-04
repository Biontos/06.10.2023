// задание 1 стр 38
int[] sequence = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int sum = 0;
foreach (int number in sequence)
{
    sum += number;
}
Console.WriteLine($"Сумма элементов последовательности: {sum}");
