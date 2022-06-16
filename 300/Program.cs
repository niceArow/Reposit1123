// Задание 2 (Серега)
int a = 0;
Console.WriteLine("Введите число, месяц и год в формате хх.хх.xxxx");
string Number = Console.ReadLine();
string Month = Console.ReadLine();
int Year = int.Parse(Console.ReadLine());
int Year1 = Year;
DateOnly now = DateOnly.Parse($"{Number}.{Month}.{Convert.ToString(Year)}");
Console.WriteLine(now + " - дата по нашему календарю");
while (Year1 > 0)
{
    Year1 = Year1 - 128;
    a++;
}
now = now.AddDays(a);
Console.WriteLine(now.ToShortDateString()+ " - дата по юлианскому календарю");
