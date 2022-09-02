// заменить в двумерном массиве все нечётные значения на противоположные по знаку
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
int[,] doubleArray = new int [m,n];

FillMatrixRandom(doubleArray, -5, 100);
PrintMatrix(doubleArray);
 
 for (int k = 0; k < doubleArray.GetLength(0); k++)
    {
        for (int l = 0; l < doubleArray.GetLength(1); l++)
        {
            if (doubleArray[k,l]%2 == 0)
            {
                doubleArray[k,l] = -doubleArray[k,l];
            }
        }
    Console.WriteLine(" ");
    }
Console.WriteLine(" ");
PrintMatrix(doubleArray);
 