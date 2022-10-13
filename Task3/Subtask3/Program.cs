using System;

class Programm{


    public static void Main(){
        int age = 27;
        Console.WriteLine("Исходный возраст {0}", age);
        ChangeAge(ref age);
        Console.WriteLine("Возраст возвращенный в функции {0}", age);
        Console.ReadKey();
    }

    static void ChangeAge(ref int age){
        age += 15;
        Console.WriteLine("Возраст измененный в функции {0}", age);
        
    }

}