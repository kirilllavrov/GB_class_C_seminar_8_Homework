Console.WriteLine("Введи размеры матрицы:");
string? lengthArray = Console.ReadLine();
string[] ArrayString = lengthArray!.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

int[] IntArray = ArrayString.Select(Int32.Parse).ToArray();

int[,] TwoArray = new int[IntArray[0], IntArray[1]];

void FillRandomTwoArray(int[,] RandomArray)
{
    for (int i = 0; i < RandomArray.GetLength(0); i++)
    {
        for (int j = 0; j < RandomArray.GetLength(1); j++)
        {
            RandomArray[i, j] = new Random().Next(1, 10);
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

FillRandomTwoArray(TwoArray);
PrintTwoArray(TwoArray);

int temp;

for (int i = 0; i < TwoArray.GetLength(1); i++)
{
    for (int k = 0; k < TwoArray.GetLength(0); k++)
    {
        for (int j = i + 1; j < TwoArray.GetLength(1); j++)
        {
            if (TwoArray[k, i] < TwoArray[k, j])
            {
                temp = TwoArray[k, i];
                TwoArray[k, i] = TwoArray[k, j];
                TwoArray[k, j] = temp;
            }
        }
    }
}

PrintTwoArray(TwoArray);