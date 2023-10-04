// задание 5 стр 31
int legs = 64;
for (int goose= 0; goose <= legs/ 2; goose++)
{
    int rab = (legs- (goose * 2))/ 4;
    int remlegs = legs - (goose * 2) - (rab * 4);
    if (remlegs == 0)
    {
        Console.WriteLine($"Гусей: {goose}, Кроликов: {rab}");
    }
}
