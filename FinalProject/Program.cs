/*
Задание:
1) Необходимо создать метод, который заполняет данные с клавиатуры по пользователю (возвращает кортеж):
    Имя;
    Фамилия;
    Возраст;
    Наличие питомца;
    Если питомец есть, то запросить количество питомцев;
    Если питомец есть, вызвать метод, принимающий на вход количество питомцев и возвращающий массив их кличек (заполнение с клавиатуры);
    Запросить количество любимых цветов;
    Вызвать метод, который возвращает массив любимых цветов по их количеству (заполнение с клавиатуры);
    Сделать проверку, ввёл ли пользователь корректные числа: возраст, количество питомцев, количество цветов в отдельном методе;
    Требуется проверка корректного ввода значений и повтор ввода, если ввод некорректен;
    Корректный ввод: ввод числа типа int больше 0.
2) Метод, который принимает кортеж из предыдущего шага и показывает на экран данные.
3) Вызов методов из метода Main.
*/
using System;

class Programm{
    public static void Main(){
        var anketa = GetDataFromConsole();
        ShowData(anketa);
        Console.ReadKey();
    }

    static (string name, string lastName, int age, bool hasPet, int countPet, string[] petNames, int countFavColors, string[] favColors) GetDataFromConsole (){   
    
        string name;                // Имя
        string lastName;            // Фамилия
        int age;                    // Возраст
        bool hasPet;                // Наличие питомца
        int countPet;               // Количество питомцев
        string[] petNames;          // Клички питомцев
        int countFavColors;         // Количество любимых цветов
        string[] favColors;         // Любимые цвета
        
        Console.WriteLine("Введите ваше имя:");
        name = Console.ReadLine();
        Console.WriteLine("Введите вашу фамилию");
        lastName = Console.ReadLine();
        
        do{
            Console.WriteLine("Введите ваш возраст");
             // Считаем, что пользователь не может ввести не число иначе требуется использовать TryParse 
            bool isAgeNumber = int.TryParse(Console.ReadLine(), out age);
            if (!IsNumberCorrect(age)||!isAgeNumber){
                Console.WriteLine("Введены некорректные данные");     
            } 
        }
        while(!IsNumberCorrect(age));
        
        string hasPetAnswer;
        do{
            Console.WriteLine("У вас есть питомец/питомцы? (Да/Нет)");
            hasPetAnswer = Console.ReadLine();
            if (!IsHasPetAnswerCorrect(hasPetAnswer)){
                Console.WriteLine("Введены некорректные данные");
            }
        }
        while (!IsHasPetAnswerCorrect(hasPetAnswer));

        hasPet = hasPetAnswer == "Да" ? true : false;

        countPet = 0;
        petNames = new string[0];

        if (hasPet){
            do {
                  Console.WriteLine("Введите количество питомцев");
                 // Считаем, что пользователь не может ввести не число иначе требуется использовать TryParse
                bool isCountPetNumber = int.TryParse(Console.ReadLine(), out countPet);
                if (!IsNumberCorrect(countPet)||!isCountPetNumber){
                    Console.WriteLine("Введены некорректные данные");
                }
            }
            while(!IsNumberCorrect(countPet));
            petNames = GetPetNames(countPet);          
        }


        do{
            Console.WriteLine("Введите количество ваших любимых цветов.");
             // Считаем, что пользователь не может ввести не число иначе требуется использовать TryParse 
            bool isCountFavColorsNumber = int.TryParse(Console.ReadLine(), out countFavColors);
            
            if (!IsNumberCorrect(countFavColors)||!isCountFavColorsNumber){
                Console.WriteLine("Введены некорректные данные");     
            } 
        }
        while(!IsNumberCorrect(countFavColors));
        favColors = GetColorNames(countFavColors);
        var result = (name, lastName, age, hasPet, countPet, petNames, countFavColors, favColors);
        return result;
    }

    static bool IsNumberCorrect(int number) => (number > 0);

    static bool IsHasPetAnswerCorrect(string data) => (data == "Да" || data == "Нет");

    static string[] GetStringArray (int num, string whatToFill){
        string[] newArray = new string[num];
        for (int i  = 0; i < newArray.Length; i++){
            Console.WriteLine("{0} №{1}",whatToFill, i+1);
            newArray[i] = Console.ReadLine();
        }
        return newArray;
    }
    static string[] GetPetNames(int num){
        Console.WriteLine("Введите клички питомцев");
        string[] petNames = GetStringArray (num, "Кличка питомца");
        return petNames;
    }
    static string[] GetColorNames(int num){
        Console.WriteLine("Введите любимые цвета");
        string[] favColors = GetStringArray (num, "Любимый цвет");
        return favColors;
    }

    static void ShowData((string name, string lastName, int age, bool hasPet, int countPet, string[] petNames, int countFavColors, string[] favColors) anketa){
        Console.WriteLine();
        Console.WriteLine("Введенные данные");
        Console.WriteLine("Ваше имя: {0}", anketa.name);
        Console.WriteLine("Ваша фамилия: {0}", anketa.lastName);
        Console.WriteLine("Ваш возраст: {0}", anketa.age);
        if (anketa.hasPet){
            Console.WriteLine("Количество ваших питомцев: {0}", anketa.countPet);
            for (int i  = 0; i < anketa.petNames.Length; i++){
                Console.WriteLine("Кличка питомца №{0}:{1}", i + 1, anketa.petNames[i]);         
            }    
        }
        else{
            Console.WriteLine("У вас нет питомцев");
        }

        Console.WriteLine("Количество ваших любимых цветов: {0}", anketa.countFavColors);
        for (int i  = 0; i < anketa.favColors.Length; i++){
            Console.WriteLine("Любимый цвет №{0}:{1}", i + 1, anketa.favColors[i]);         
        }
    }    
}