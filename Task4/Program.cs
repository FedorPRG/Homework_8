void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]} - {i}, {j}, {k}.");
                Console.WriteLine();
            }
        }
    }
}

void FillArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j, 0] = new Random().Next(10, 100);            
            for (int k = 1; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = new Random().Next(10, 100);
                for (int l = 0; l < matr.GetLength(0); l++)
                {
                    for (int m = 0; m < matr.GetLength(1); m++)
                    {                       
                        for (int n = 0; n < k; n++)
                        {
                            if (matr[i, j, k] == matr[l, m, n])
                            {
                                k--; 
                            }
                        }
                    }
                }
            }
        }
    }
}
Console.Write("Введите первый размер массива: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите второй размер массива: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Введите третий размер в массива: ");
int l = int.Parse(Console.ReadLine()!);

int[,,] matrix = new int[m, n, l];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
