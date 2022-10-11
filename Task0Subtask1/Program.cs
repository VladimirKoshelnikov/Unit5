using System;

class Programm{
    public static void Main(){
        (string Name, string[] Dishes) User;
        User.Dishes = new string[5];

        Console.WriteLine("Введите имя пользователя");
        User.Name = Console.ReadLine();

        for( int i = 0; i<User.Dishes.Length; i++){
            Console.WriteLine($"Введите любимое блюдо №{i + 1} пользователя");
            User.Dishes[i] = Console.ReadLine();   
        }

        Console.ReadKey();

    }
}