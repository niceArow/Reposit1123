// Задание 4 (Костик)
Random rand = new Random();
int sravn_chislo = rand.Next(10);
int count = 1;
Console.WriteLine("Компьютер загадал число от 0 до 9. Попробуйте отгадать его. На это у вас есть 3 попытки");
Console.Write("Введите первое число: ");
int vvod = Convert.ToInt32(Console.ReadLine());
while (count <= 3)
{
    if (sravn_chislo > vvod)
    {
        Console.WriteLine("Не угадал, это не " + vvod + "! Загаданное число больше. Попытка № " + count + ":");

        vvod = Convert.ToInt32(Console.ReadLine());
    }
    if (sravn_chislo < vvod)
    {
        Console.WriteLine("Не угадал, это не " + vvod + "! Загаданное число меньше. Попытка № " + count + ":");

        vvod = Convert.ToInt32(Console.ReadLine());
    }
    if (sravn_chislo == vvod)
    {
        Console.WriteLine("Поздравляю, ты угадал! Компьютер загадал число " + vvod + "!");
        break;
    }

    else
    {
        count++;
        if (count == 3)
        {
            Console.WriteLine("К сожалению, вы не отгадали число. Загаданным числом была цифра " + sravn_chislo + "!");
            break;
        }
    }

}
Console.ReadLine();