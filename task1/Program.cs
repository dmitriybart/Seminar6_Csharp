// заполинть двумерный массив(матрицу)

void FillMatrixRandom (int[,] matrix, int min, int max)
{
    var random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(min,max+1);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");

        }
        Console.WriteLine(" ");
        Console.WriteLine(" ");
    }
    
}

Console.Clear();
int m,n;
m = int.Parse(Console.ReadLine() ?? "0");
n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(" ");
int[,] dubleArray = new int [m,n];
FillMatrixRandom(dubleArray, -5, 10);
PrintMatrix(dubleArray);