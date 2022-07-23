int [,,] InitMatrix(int n)
{
    int[,,] matrix = new int[n, n, n];
    Random randomizer = new Random();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n; k++)
            {
                matrix[i, j, k] = randomizer.Next(1, 10)*10+randomizer.Next(1, 10);
            }
           
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix, int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n; k++)
            {
                Console.Write($"{matrix[i, j, k]}({i}, {j}, {k})  ");
            }
            
        }
        Console.WriteLine();
    }
}
int n = 2;
int[,,] matrix = InitMatrix(n);
PrintMatrix(matrix, n);