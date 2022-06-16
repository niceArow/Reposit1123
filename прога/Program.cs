// Задание 5 (Слава)
int[] myArray = { 13, 22, 34, 975, 12, 45, 3, 1, 87, 876, 51, 85 };
int[] zam1 = new int[12];
int[] zam2 = new int[12];
Console.WriteLine("Изначальный массив: ");
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($" {myArray[i]}");
}
for (int i = 0; i < myArray.Length; i++)
{
    zam1[i] = myArray[myArray.Length - 1 - i];
}
Console.WriteLine();
for (int i = 0; i < zam2.Length; i++)
{
    zam2[i] = zam1[i];
    if (i < 6)
    {
     if (i > 0)
     {
         zam2[i + i] = zam1[i + i + 1];
     }
    }
}
Console.WriteLine("Массив поменяный местами: ");
for (int i = 0; i < zam2.Length; i++)
{
    Console.Write($" {zam2[i]}");
}
Console.WriteLine();
