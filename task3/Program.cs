// Найти в двумерном массиве число заданное пользователем
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

void IndexOf(int[,]matrix, int find)
{
bool q = false;
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] == find)
            {
                Console.WriteLine($"Позиция числа {find}: ({i},{j})");
                q = true;
            }
        }
    }
    if(q==false) Console.WriteLine("Такого числа нет в массиве");
}

Console.Clear();
int m,n,x;
m = int.Parse(Console.ReadLine() ?? "0");
n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(" ");
int[,] dubleArray = new int [m,n];
FillMatrixRandom(dubleArray, -5, 100);
PrintMatrix(dubleArray);
Console.WriteLine(" ");
x = int.Parse(Console.ReadLine() ?? "0");
IndexOf(dubleArray, x);