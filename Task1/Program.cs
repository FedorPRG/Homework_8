void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

Console.Write("Введите число строк в массиве: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов в массиве: ");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int position = 0; position < matrix.GetLength(1); position++)
    {
        int max = matrix[i, position], save, iSearch=i, jSearch=position;
        for (int j = position; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > max)
            {
                max = matrix[i, j]; 
                iSearch = i;
                jSearch = j;
            }
        }
        save = matrix[i, position];
        matrix[i, position] = max;
        matrix[iSearch, jSearch] = save;
    }
}
PrintArray(matrix);


