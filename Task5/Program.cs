int [,] InitMatrix(int n)
{
    int [,] matrix = new int[n,n];
    int count = 1;
    int m= 0;
    int i= 0;
    int j= 0;
    int res = n*n;
    while (count<=res)
    {
       for (int k = m; k <n; k++)
            {
               matrix [i,k] = count;
               count++; 
            }
        j= n-1;
       for (int k = m+1; k <n; k++)
            {
                matrix [k,j] = count;
                count++; 
            }
        i= n-1;
        for (int k =n-2; k >=m ; k--)
            {
                matrix [i, k] = count;
                count++; 
            }
        j = m;
        for (int k = n-2; k >m; k--)
            {
                matrix [k, j] = count;
                count++; 
            }
        i=m+1;
        n--;
        m++;
        j=m;
        
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

int [,] matrix = InitMatrix(4);
PrintMatrix(matrix);