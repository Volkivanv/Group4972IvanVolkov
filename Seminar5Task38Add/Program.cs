// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// (со звездочкой) Отсортируйте массив методом вставки и методом подсчета,
//  а затем найдите разницу между первым и последним элементом. Для задачи со звездочкой 
//  использовать заполнение массива целыми числами.
//
// Задача для целых чисел и сортировки подсчетом

//Инициализация массива
int[] RandomArray(int len, int lowBorder, int highBorder)
{
    int[] rA = new int[len];
    for (int i = 0; i < len; i++)
    {
        rA[i] = new Random().Next(lowBorder, highBorder + 1);
    }
    return rA;
}
//Вывод массива
void OutPutArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// сортировка подсчетам
void CountSort(int[] arr)
{
    MinMax mM = FindMinMax(arr); //нахдим максимальное и минимальное
    int maxDif = mM.max - mM.min; // разница между ними
    int[] arrPos = new int[arr.Length]; //новый массив

    //создаем вспомогательный массив для подсчета
    int[] c = new int[maxDif + 1];
    //производим подсчет
    for (int i = 0; i < arr.Length; i++)
    {
        c[arr[i] - mM.min]++;  //от значения каждого элемента отнимаем минимум чтобы минимум обнулить
    }
    //разбираем получившийся массив для подсчета
    int j = 0;
    for (int i = 0; i < c.Length; i++)
    {
        while (c[i] > 0)
        {
            arr[j] = i + mM.min;
            j++;
            c[i]--;
        }
    }
}

 void InsertionSort(int[] arr)
  {
    for(int j = 2; j < arr.Length;j++)
    {
      int key = arr[j];
      int i = j - 1;
      while(i >=0 && arr[i] > key)
      {
        arr[i+1] = arr[i];
        i--;
      }
      arr[i+1] = key;
    }
  }

MinMax FindMinMax(int[] arr) // поиск минимального и максимального значения
{
    MinMax mm = new MinMax();
    mm.min = arr[0];
    mm.max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < mm.min) mm.min = arr[i];
        if (arr[i] > mm.max) mm.max = arr[i];
    }
    return mm;
}


Console.Clear();
int[] intArr = RandomArray(10, -20, 20);
Console.WriteLine("Исходный массив");
OutPutArray(intArr);
CountSort(intArr);
Console.WriteLine("Отсортированный массив");
OutPutArray(intArr);
Console.WriteLine($"Разность между максимальным и минимальным: {intArr[intArr.Length - 1] - intArr[0]}");

int[] intArr2 = RandomArray(10, -25, 20);
Console.WriteLine("Исходный массив 2");
OutPutArray(intArr);
InsertionSort(intArr);
Console.WriteLine("Отсортированный массив 2");
OutPutArray(intArr);

// класс для минимального и максимального значения
public class MinMax
{
    public int min;
    public int max;
}
