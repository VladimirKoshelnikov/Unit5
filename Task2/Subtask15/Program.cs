using System;

class Programm{


    public static void Main(){
        int[] myArray = GetArrayFromConsole();
        int[] sortedArray = SortArray(myArray);
        
        Console.WriteLine("Введенный массив");
        for (int i = 0; i < myArray.Length; i++){
            Console.Write($" {myArray[i]}");
        }
        Console.WriteLine();
        Console.WriteLine("Отсортированный массив");
        for (int i = 0; i < sortedArray.Length; i++){
            Console.Write($" {sortedArray[i]}");
        }
        Console.ReadKey();
    }

    static int[] GetArrayFromConsole(int count = 5){
        int[] newArray = new int[count];

        Console.WriteLine("Введите массив:");
        Console.WriteLine();

        for (int i = 0; i < count; i++){
            Console.Write("Элемент № {0}: ", i + 1);
            newArray[i] = int.Parse(Console.ReadLine());
        } 
        
        return newArray;
    }
  
    static int[] SortArray(int[] array){
        
        int[] result = new int[array.Length];
        for (int i = 0; i < array.Length; i++){
            result[i] = array[i];
        }
        
        int temp;
        for(int i = 0; i < result.Length; i++){
            for(int j = 0; j < result.Length; j++){
                if (result[j] > result[i]){
                    temp = result[i];
                    result[i] = result[j];
                    result[j] = temp;
                }
            }
        }

        return result;
    }
}