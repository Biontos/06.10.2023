// задание 6 стр 38
int[] sequence = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int product = 1;
foreach (int number in sequence)
{
    product *= number;
}
Console.WriteLine($"Произведение элементов последовательности: {product}");
