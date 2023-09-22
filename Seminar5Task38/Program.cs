// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// (со звездочкой) Отсортируйте массив методом вставки и методом подсчета,
//  а затем найдите разницу между первым и последним элементом. Для задачи со звездочкой 
//  использовать заполнение массива целыми числами.

//Инициализация массива вещественных чисел  
double[] RandomArray(int len, double lowBorder, double highBorder){
    double[] rA = new double[len];
    for(int i = 0; i < len; i++)
    {
        rA[i] = new Random().NextDouble()*
      (highBorder - lowBorder) - (highBorder - lowBorder)/2;
    }
    return rA;
}
// вывод массива вещественных чисел
 void OutPutArray(double[] arr){
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++){
        Console.Write( arr[i] + ",");
    }
    Console.WriteLine( arr[arr.Length - 1] +"]");
}

// метод сортировки вставками
 void InsertionSort(double[] arr)
  {
    for(int j = 2; j < arr.Length;j++)
    {
      double key = arr[j];
      int i = j - 1;
      while(i >=0 && arr[i] > key)
      {
        arr[i+1] = arr[i];
        i--;
      }
      arr[i+1] = key;
    }
    
  }

  
    Console.Clear();
    double[] arr = RandomArray(10,-20.0, 20.0);
    Console.WriteLine("Исходный массив");
    OutPutArray(arr);
    InsertionSort(arr);
    Console.WriteLine("Исходный массив");
    OutPutArray(arr);
    Console.WriteLine($"Минимальный элемент {arr[0]}, а максимальный {arr[arr.Length - 1]}");
    Console.WriteLine($"Разность между ними {arr[arr.Length - 1] - arr[0]}");
