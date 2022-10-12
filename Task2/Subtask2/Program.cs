using System;
class MainClass
{
    public static void Main(string[] args)
    {
        (string name, int age) anketa;

        Console.WriteLine("Введите ваше имя");
        anketa.name = Console.ReadLine();
        Console.WriteLine("Введите ваш возраст");
        anketa.age = int.Parse(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", anketa.name);
        Console.WriteLine("Ваш возраст: {0}", anketa.age);

        string[] favcolors = new string[3];
        for (int i = 0; i < favcolors.Length; i++){
            favcolors[i] = ShowColor(anketa.name);
        }

        
        Console.WriteLine("Ваши любимые цвета");
        foreach (string color in favcolors){
            Console.WriteLine(color);
        }
        Console.ReadKey();
    }


        static string ShowColor(string username){
        
        Console.WriteLine("{0}, напишите свой любимый цвет на английском с маленькой буквы", username);
            var color = Console.ReadLine();
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is default!");

                    break;
            }
            return color;
    }
}