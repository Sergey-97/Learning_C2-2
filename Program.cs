Console.WriteLine("Введите число дня недели: ");
int weekNumber = int.Parse(Console.ReadLine());
if (weekNumber == 6 || weekNumber == 7)
{
    Console.Write($"{weekNumber} день недели это ВЫХОДНОЙ");
}
else
{
    Console.Write($"{weekNumber} день недели это НЕ ВЫХОДНОЙ");
}