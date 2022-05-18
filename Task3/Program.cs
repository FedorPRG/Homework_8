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
            matr[i, j] = new Random().Next(1, 3);
        }
    }
}
Console.Write("Введите число строк в первом массиве: ");
int m1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов в первом массиве: ");
int n1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число строк во втором массиве: ");
int m2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов во втором массиве: ");
int n2 = int.Parse(Console.ReadLine()!);
if (n1!=m2)
{
    Console.WriteLine($"Число столбцов в первой матрице {n1} не равно числу строк во второй матрице {m2} "
    +"- произведение заданных матриц не возможно");
    return;
}
int[,] matrix1 = new int[m1, n1];
int[,] matrix2 = new int[m2, n2];
int[,] matrixSum = new int [m1,n2];
FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int k = 0; k < matrix1.GetLength(0); k++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrixSum[i,k]=matrixSum[i,k]+matrix1[i,j]*matrix2[j,k];
        }        
    }
}
PrintArray(matrixSum);