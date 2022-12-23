int[,,] Array = new int[3, 3, 3];


int num = 10;

for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        for (int k = 0; k < Array.GetLength(2); k++)
        {
            Array[i, j, k] = num;
            num++;
        }
    }
}

for (int i = 0; i < Array.GetLength(0); i++)
{

    for (int j = 0; j < Array.GetLength(1); j++)
    {
        for (int k = 0; k < Array.GetLength(2); k++)
        {

            Console.Write($"{Array[i, j, k]} ");
            Console.WriteLine($"- ({i}," + $"{j}," + $"{k})");
        }
        Console.WriteLine();
    }
}