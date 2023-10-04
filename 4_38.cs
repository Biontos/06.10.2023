// задание 4 стр 38
int[] vso = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
int tarNum = 1;
int count = 0;
foreach (int num in vso)
{
    if (num == tarNum)
    {
        count++;
    }
}
Console.WriteLine($"Число {tarNum} встречается в последовательности {count} раз ");