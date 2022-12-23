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

int Sum = 0;
int[,] SumArray = new int[2, TwoArray.GetLength(0)];

for (int i = 0; i < TwoArray.GetLength(0); i++)
{
    for (int j = 0; j < TwoArray.GetLength(1); j++)
    {
        Sum = Sum + TwoArray[i, j];
    }

    //Console.WriteLine($"Сумма элементов строки {i + 1} равно: {Sum}");  // Для контроля
    SumArray[0, i] = Sum;
    SumArray[1, i] = i + 1;
    Sum = 0;
}


//int MinSum = SumArray[0, 0];
int MinIndex = 1;

for (int i = 0; i < SumArray.GetLength(1); i++)
{
    if (SumArray[0, i] < SumArray[0, 0])
    {
        //MinSum = SumArray[0, i];
        MinIndex = SumArray[1, i];
    }
}

//Console.WriteLine(MinSum);
Console.WriteLine($"Строка с наименьшей суммой элементов: {MinIndex}");