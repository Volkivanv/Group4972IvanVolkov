int[] RandomArray(int len, int lowBorder, int highBorder){
    int[] rA = new int[len];
    for(int i = 0; i < len; i++)
    {
        rA[i] = new Random().Next(lowBorder, highBorder+1);
    }
    return rA;
}

void OutPutArray(int[] arr){
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++){
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine( arr[arr.Length - 1] +"]");
}

int[] Multiplex(int[] arr)
{
    int[] output = new int[arr.Length/2];
    for(int i = 0; i < arr.Length/2; i++)
    {
       output[i] = arr[i]*arr[arr.Length-1-i];
    }
    return output;
}


int[] array = RandomArray(10, 0, 10);
OutPutArray(array);
int[] outarr = Multiplex(array);
OutPutArray(outarr);