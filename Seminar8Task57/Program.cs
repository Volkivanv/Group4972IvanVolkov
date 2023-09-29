// Задача 57:
// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}


int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = new Random().Next(downBorder, topBorder + 1);
        }
    }
    return array2D;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Dictionary<int, int> FreqDict(int[,] matrix)
{
    Dictionary<int, int> freqDict = new Dictionary<int, int>();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (freqDict.ContainsKey(matrix[i, j]))
            {
                freqDict[matrix[i, j]]++;
            }
            else
            {
                freqDict.Add(matrix[i, j], 1);
            }
        }
        Console.WriteLine();
    }
    return freqDict;
}

void PrintDicitonary(Dictionary<int, int> freqDict)
{
    var sortedDict = from entry in freqDict orderby entry.Value ascending select entry;
    foreach(var item in sortedDict)
    {
        Console.WriteLine($"Значение{item.Key}, количество {item.Value}");
    }
}
Console.Clear();
int n = ReadData("Количество строк: ");
int m = ReadData("Количество столбцов: ");
Console.WriteLine("Исходная матрица");
int[,] array2D = Fill2DArray(n, m, 10, 1);
Print2DArray(array2D);
Console.WriteLine("________________");
Dictionary<int, int> dict = FreqDict(array2D);

PrintDicitonary(dict);