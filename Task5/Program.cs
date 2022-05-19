void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < 10) Console.Write($" {matr[i, j]} ");
            else Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr, int k)
{
    if (k == 0)
    {
        for (int j = k + 1; j < matr.GetLength(1); j++)
        {
            matr[k, j] = matr[k, j - 1] + 1;
        }
    }
    else
    {
        for (int j = k; j < matr.GetLength(1) - k; j++)
        {
            matr[k, j] = matr[k, j - 1] + 1;
        }
    }
    for (int i = k + 1; i < matr.GetLength(0) - k; i++)
    {
        matr[i, matr.GetLength(1) - k - 1] = matr[i - 1, matr.GetLength(1) - k - 1] + 1;
    }
    for (int j = matr.GetLength(1) - k - 2; j >= k; j--)
    {
        matr[matr.GetLength(0) - k - 1, j] = matr[matr.GetLength(0) - k - 1, j + 1] + 1;
    }
    for (int i = matr.GetLength(1) - k - 2; i > k; i--)
    {
        matr[i, k] = matr[i + 1, k] + 1;
    }
}
Console.Write("Матрица размером nxn. Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[n, n];
matrix[0, 0] = 1;
for (int k = 0; k < n / 2; k++)
{
    FillArray(matrix, k);
}
if (n % 2 > 0) matrix[n / 2, n / 2] = n * n;
PrintArray(matrix);