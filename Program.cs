int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(1, 9);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void SelectionSort(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            int max = j;
            int temp;
            for (int l = j + 1; l < matrix.GetLength(1); l++)
            {
                if (matrix[i, l] > matrix[i, max]) 
                max = l;
            }
            temp = matrix[i, j];
            matrix[i, j] = matrix[i, max];
            matrix[i, max] = temp;
        }
    }
}

int[,] matrix = GetMatrix(5, 5);
PrintMatrix(matrix);
System.Console.WriteLine();
SelectionSort(matrix);
PrintMatrix(matrix);
