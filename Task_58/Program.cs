Console.WriteLine("Введи размеры матрицы:");
string? lengthArray = Console.ReadLine();
string[] ArrayString = lengthArray!.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

int[] IntArray = ArrayString.Select(Int32.Parse).ToArray();

// Произведение двух матриц можно найти только в случае, если количество столбцов матрицы А совпадает с количеством строк матрицы В
// поэтому упростим себе жизнь...

int[,] TwoArrayA = new int[IntArray[0], IntArray[1]];

int[,] TwoArrayB = new int[IntArray[1], IntArray[0]];

int[,] TwoArrayС = new int[TwoArrayA.GetLength(0), TwoArrayB.GetLength(1)];

void FillRandomTwoArray(int[,] RandomArray)
{
    for (int i = 0; i < RandomArray.GetLength(0); i++)
    {
        for (int j = 0; j < RandomArray.GetLength(1); j++)
        {
            RandomArray[i, j] = new Random().Next(1, 3);
        }
    }
}

void PrintTwoArray(int[,] ShowTwoArray)
{
    for (int i = 0; i < ShowTwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < ShowTwoArray.GetLength(1); j++)
        {
            Console.Write($"{ShowTwoArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillRandomTwoArray(TwoArrayA);
FillRandomTwoArray(TwoArrayB);

PrintTwoArray(TwoArrayA);      // Для самопроверки
Console.WriteLine();
PrintTwoArray(TwoArrayB);

// нужно перемножить строки матрицы A на столбцы матрицы B и суммы упаковать в матрицу C (если я правильно понял смысл умножения двух матриц)

for (int i = 0; i < TwoArrayA.GetLength(0); ++i)             // строки массива A
{
    for (int j = 0; j < TwoArrayB.GetLength(1); ++j)         // столбцы массива B
    {
        for (int k = 0; k < TwoArrayA.GetLength(1); ++k)
        {
            TwoArrayС[i, j] = TwoArrayС[i, j] + TwoArrayA[i, k] * TwoArrayB[k, j];
        }
    }
}
Console.WriteLine();
PrintTwoArray(TwoArrayС);