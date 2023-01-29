string[] Mas = new string[10] { "777", "Tim", "13", "mas", "world", "-2", ":)", "Russian", "computer science", "Simba" };
string[] MasNew = new string[Mas.Length];
void SecondMas(string[] Mas, string[] MasNew)
{
    int count = 0;
    for (int i = 0; i < Mas.Length; i++)
    {
        if (Mas[i].Length <= 3)
        {
            MasNew[count] = Mas[i];
            count++;
        }
    }
}
void PrintMas(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondMas(Mas, MasNew);
Console.WriteLine($"Массив из строк, длина которых меньше или равно 3: ");
PrintMas(MasNew);
