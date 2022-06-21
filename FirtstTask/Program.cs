int [] createArrey(){
    Console.WriteLine("Количество элементов в массиве: ");
    int sizeArr = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int [sizeArr];

    return arr;
}

int[] fillArrey(int[] arr){
        for(int i = 0; i < arr.Length; i++){
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

void showArrey(int[] arr){
    for(int i = 0; i < arr.Length; i++){
        Console.Write($"{arr[i]} {" "}");
    }
}

int evenSearch(int[] arr){
    int counter = 0;
    for(int i = 0; i < arr.Length; i++){
        if(arr[i] % 2 == 0){
            counter++;
        }
    }
    return counter;
}

int[]arr = createArrey();
fillArrey(arr);
showArrey(arr);
Console.WriteLine();
Console.WriteLine($"{"Четных чисел в массиве: "} {evenSearch(arr)}");
