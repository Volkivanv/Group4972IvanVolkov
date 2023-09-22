int[] randomArray(int len, int lowBorder, int highBorder){
    int[] rA = new int[len];
    for(int i = 0; i < len; i++)
    {
        rA[i] = new Random().Next(lowBorder, highBorder+1);
    }
    return rA;
}

void outPutArray(int[] arr){
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++){
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine( arr[arr.Length - 1] +"]");
}

void AntiArray(int[] arr)
{
    for(int i = 0; i <arr.Length; i++)
    {
        arr[i]*=-1;
    }
}

int[] array = randomArray(12, -10, 10);
outPutArray(array);
AntiArray(array);
outPutArray(array);