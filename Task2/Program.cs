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
            matr[i, j] = new Random().Next(1, 3);//специально, чтобы было несколько строк
             //с одинаковой минимальной суммой
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

int[] sum = new int[matrix.GetLength(0)];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sumrow = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sumrow = sumrow + matrix[i, j];
    }
    sum[i] = sumrow;
}
int min = sum[0];
int iSearch=0;
for (int i = sum.Length-1; i > -1; i--)//чтобы при выводе можно было поставить точку
{
    if (min > sum[i])
    {
        min = sum[i];
        iSearch=i;       
    }
}
Console.Write("Номера строк с наименьшей суммой элементов: ");
for (int i = 0; i < iSearch; i++)
{
    if (sum[i] == min)
    {
        Console.Write(i + ", ");
    }
}
Console.Write(iSearch+".");