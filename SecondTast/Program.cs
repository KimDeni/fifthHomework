int [] createArrey(){
    Console.WriteLine("Количество элементов в массиве: ");
    int sizeArr = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int [sizeArr];

}

int[] fillArrey(int[] arr){
        for(int i = 0; i < arr.Length; i++){
        arr[i] = new Random().Next(-20, 50);
    }
    return arr;
}

void showArrey(int[] arr){
    for(int i = 0; i < arr.Length; i++){
        Console.Write($"{arr[i]} {" "}");
    }
}

int summ(int[] arr){
    int rez = 0;
    
    for (int i = 0; i < arr.Length; i++){
        if (i % 2 != 0){
            rez = rez + arr[i];
        }
    }
    return rez;
}

int[]arr = createArrey();
fillArrey(arr);
showArrey(arr);
Console.WriteLine();
Console.WriteLine($"{"Сумма элементов, стоящих на нечётных позициях: "} {summ(arr)}");
