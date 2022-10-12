using System;

class Programm{


    public static void Main(){
        int[] myArray;
        myArray = GetArrayFromConsole();
        Console.WriteLine("Введенный массив");
        for (int i = 0; i < myArray.Length; i++){
            Console.Write($" {myArray[i]}");
        }
        Console.ReadKey();
    }

    static int[] GetArrayFromConsole(){
        Console.WriteLine("Введите длину массива");
        int count = int.Parse(Console.ReadLine());
        int[] newArray = new int[count];

        Console.WriteLine("Введите массив:");
        Console.WriteLine();

        for (int i = 0; i < count; i++){
            Console.Write("Элемент № {0}: ", i + 1);
            newArray[i] = int.Parse(Console.ReadLine());
        } 
        SortArray(newArray);
        
        return newArray;
    }
  
    static void SortArray(int[] array){
        int temp;
        
        for(int i = 0; i < array.Length; i++){
            for(int j = 0; j < array.Length; j++){
                if (array[j] > array[i]){
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
}