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
void FindMinimumSum(int [,] matrix, int sum)
{
    int stringnumber=0; 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumforstr = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumforstr=sumforstr+matrix[i,j];
        }
        if (sumforstr<sum)
        {
            stringnumber = i;
            sum = sumforstr;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой {stringnumber+1}"); //мы выводим номер строки с точки зрения зрителя, т.е 0 строка - 1
}
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] matrix = InitMatrix(m, n);
int sum = 100000;
PrintMatrix(matrix);
FindMinimumSum(matrix, sum);