using System;

class MainClass {
  static void Main(string[] args) {
    byte pow = 4;
    int num = 5;

    Console.WriteLine("Программа возводит число num в степень pow:");
    Console.WriteLine("Введите число num");
    num = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число pow");
    pow = byte.Parse(Console.ReadLine());

    decimal result;
    result = PowerUp(num, pow);

    Console.WriteLine("Число {0} в степени {1} = {2}",num, pow, result);
    Console.ReadKey();
  }

  static decimal PowerUp(int num, byte pow){
    if (pow == 0){
        return 1;
    }
    else {
        pow--;
        return num * PowerUp (num , pow);
    }
  }
}