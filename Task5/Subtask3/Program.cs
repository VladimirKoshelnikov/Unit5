using System;

class MainClass {
  static void Main(string[] args) {
  Console.WriteLine("Напишите что-то");
  var str = Console.ReadLine();

  Console.WriteLine("Укажите глубину эха");
  var deep = int.Parse(Console.ReadLine());

  Echo(str, deep);

  Console.ReadKey();
}

static void Echo(string phrase, int deep) {
  string modif = phrase;
  
  if (modif.Length > 2){
    modif = modif.Remove(0, 2);
  }
  
  Console.WriteLine("...{0}", modif);

  if (deep > 1) {
    Echo(modif, deep - 1);
  }
}

}