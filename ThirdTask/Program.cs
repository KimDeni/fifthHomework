int [] createArrey(){
    Console.WriteLine("Количество элементов в массиве: ");
    int sizeArr = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int [sizeArr];

    return arr;
}

int[] fillArrey(int[] arr){
        for(int i = 0; i < arr.Length; i++){
        arr[i] = new Random().Next(-10, 50);
    }
    return arr;
}

void showArrey(int[] arr){
    for(int i = 0; i < arr.Length; i++){
        Console.Write($"{arr[i]} {" "}");
    }
}

int diff(int[] arr){
    int min = arr[0];
    int max = arr[0];
    int rez;

    for( int i = 1; i < arr.Length; i++){
        if (max < arr[i]){
            max = arr[i];
        }
        if (min > arr[i]){
            min = arr[i];
        }
    }
    rez = max - min;
    return rez;
}

int[]arr = createArrey();
fillArrey(arr);
showArrey(arr);
Console.WriteLine();
Console.WriteLine(diff(arr));