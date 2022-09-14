// Задача:
// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Массив можно ввести с клавиатуры, либо
// задать на старте алгоритма.

string[] ArrayFirst = new string[6] { "2h", "p9", "59830", "2", "res", "sonya" };
string[] ArrayLength = new string[ArrayFirst.Length];
void ArraySolution(string[] ArrayFirst, string[] ArrayLength)

{
    int count = 0;
    for (int i = 0; i < ArrayFirst.Length; i++)
    {
        if (ArrayFirst[i].Length <= 3)
        {
            ArrayLength[count] = ArrayFirst[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArraySolution(ArrayFirst, ArrayLength);
PrintArray(ArrayLength);

