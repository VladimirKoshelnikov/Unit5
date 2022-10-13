using System;

class Programm{


    public static void Main(){
        int[] myArray = GetArrayFromConsole(10);
        int[] mySortedDescArray, mySortedAscArray;
        SortArray(myArray, out mySortedDescArray, out mySortedAscArray); 
        
        Console.WriteLine("Исходный массив");
        ShowArray(myArray);
        
        Console.WriteLine("Массив отсортированный по возрастанию");
        ShowArray(mySortedAscArray);
        
        Console.WriteLine("Массив отсортированный по убыванию");
        ShowArray(mySortedDescArray);
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
  
    static void SortArray(int[] array, out int[] sortedDescArray, out int[] sortedAscArray){
        sortedDescArray = SortArrayDesc(array);
        sortedAscArray = SortArrayAsc(array);
    }

// Сортировка массива от большего к меньшему
    static int[] SortArrayDesc(int[] array){
        
        int[] result = new int[array.Length];
        for (int i = 0; i < array.Length; i++){
            result[i] = array[i];
        }
        
        int temp;
        for(int i = 0; i < result.Length; i++){
            for(int j = 0; j < result.Length; j++){
                if (result[j] < result[i]){
                    temp = result[i];
                    result[i] = result[j];
                    result[j] = temp;
                }
            }
        }

        return result;
    }

// Сортировка массива от меньшего к большему
    static int[] SortArrayAsc(int[] array){
        
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


    
    
    static void ShowArray (int[] array){
        for (int i = 0; i < array.Length; i++){
            Console.Write("{0} ",array[i]);
        }
        Console.WriteLine();
    }
}