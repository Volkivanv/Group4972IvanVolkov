// №36 Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// (со звездочкой) Найдите все пары в массиве и выведите пользователю

int[] RandomArray(int len, int lowBorder, int highBorder)
{ //инициализация массива
    int[] rA = new int[len];
    for (int i = 0; i < len; i++)
    {
        rA[i] = new Random().Next(lowBorder, highBorder + 1);
    }
    return rA;
}

void OutPutArray(int[] arr) // вывод массива
{
    Console.WriteLine($"{String.Join(',', arr)}");
}

static void QuickSort(int[] arr, int first, int last) //метод быстрой сортировки массива
{
    int i = first;
    int j = last;
    int pivot = (first + last) / 2; //выбираем опорный элемент
    while (i < j) // идем по i с начала, по j с конца, находим слева 
    // элемент больше arr[pivot] а справа меньше и обмениваем их
    {
        while (arr[i] < arr[pivot])
        {
            i++;
        }
        while (arr[j] > arr[pivot])
        {
            j--;
        }
        if (i <= j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            i++;
            j--;
        }
    }
    // рекурсивно применяем к массивам справа и слева от места встречи i и j
    if (first < j) QuickSort(arr, first, j);
    if (i < last) QuickSort(arr, i, last);
}

Pair[] FillPairs(int[] arr) // создание и заполнение массива пар чисел
{
    Pair[] resultPairs = Array.Empty<Pair>(); // создаем пустой массив
    QuickSort(arr, 0 , arr.Length-1); // сортируем быстрой сортировкой
    int i = 0;
    while (i < arr.Length - 1) // проходим по отсортированному массиву
    {
        if (arr[i] == arr[i + 1]) // если встрелась пара 
        //аписываем ее в массив пар и увеличиваем счетчик на 2
        {

            Pair tempPair = new Pair();
            tempPair.first = arr[i];
            tempPair.second = arr[i + 1];
            resultPairs = resultPairs.Append(tempPair).ToArray();
            i += 2; 
        }
        else i++; // если не встретилась, то на один
    }
    return resultPairs; 
}

void OutPutPairArray(Pair[] pairs) // вывод для массива пар
{
    if (pairs.Length > 0)
    {
        Console.WriteLine("В массиве имеются следующие пары:");
        for (int i = 0; i < pairs.Length; i++)
        {
            Console.Write($"({pairs[i].first}, {pairs[i].second});");
        }
    }
    else
    {
        Console.WriteLine("Пар не найдено");
    }
    Console.WriteLine();
}



Console.Clear();
int[] array = RandomArray(30, 0, 10);
// исходный массив
OutPutArray(array);
Pair[] pairs = FillPairs(array);
// массив пар чисел
OutPutPairArray(pairs);

public class Pair // класс пар
{
    public int first;
    public int second;
}
