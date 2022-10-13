using System;

class Programm{


    public static void Main(){
        int count = 10;
        int[] myArray = GetArrayFromConsole(ref count);
        ShowArray(myArray, true);
        Console.ReadKey();
    }

    static int[] GetArrayFromConsole(ref int count){
        count = 6;
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

    static void ShowArray (int[] array, bool needSort = false){
        if (needSort){
            array = SortArray(array);
            Console.WriteLine("Отсортированный массив");
        }
        else{
            Console.WriteLine("Введенный массив");
        }

        for (int i = 0; i < array.Length; i++){
            Console.Write("{0} ",array[i]);
        }
    }
}