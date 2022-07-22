int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = randomizer.Next(1, 10);
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
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}
int [,] SortingMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k< matrix.GetLength(1)-1; k++)
        
        {
            for (int j = 0; j < matrix.GetLength(1)-1; j++)
            {
                
                if (matrix[i,j]<matrix[i,j+1])
                {
                    int temp = matrix[i,j+1];
                    matrix[i,j+1]=matrix[i,j];
                    matrix[i,j]=temp;
                }
            }
        }
    }
    return matrix;
}
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
int [,] newmatrix= SortingMatrix(matrix);
PrintMatrix(newmatrix);
