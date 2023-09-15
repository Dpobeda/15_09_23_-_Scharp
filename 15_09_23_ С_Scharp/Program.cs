

/*
 * ..................................WriteLine....................................
 
 Метод WriteLine в C# является методом класса System.Console и используется для вывода данных на консоль.
Он выводит заданную строку, а затем переводит курсор на новую строку.

Пример использования:

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

...........................ReadLine...........................................

ReadLine в C# - это метод, который считывает строку из стандартного потока ввода (обычно с клавиатуры).
Он является частью класса System.Console и позволяет считывать текст по строкам.

Пример использования ReadLine:

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();
        Console.WriteLine($"Вы ввели: {input}");
    }
}
В этом примере мы просим пользователя ввести строку, а затем выводим введенную строку на экран.


Паскаль Кейс - Все писать с большой буквы 

..........................convert...............................................

В C# слово convert может относиться к нескольким различным понятиям. Вот некоторые из них:

Метод Convert в классе System.Convert используется для преобразования одного типа данных в другой. 
Например, Int32.Parse("10") может быть заменен на Convert.ToInt32("10").
Класс XmlConvert в пространстве имен System.Xml предоставляет методы для конвертации различных типов данных, 
таких как Boolean, DateTime и TimeSpan, в строки и обратно.
Ключевое слово implicit или explicit при определении типа может использоваться для указания неявного
или явного преобразования между этим типом и другими типами.
В LINQ to SQL и Entity Framework есть понятие конвертера значений, 
которое позволяет преобразовывать значения объектов в другие типы данных.

.........................var...............................................
Это как /auto/

Это ключевое слово, которое указывает,
что переменная должна быть автоматически типизирована.
То есть тип переменной будет выбран компилятором на основе того, как она используется.

DLL 

Это библиотека динамической компоновки, которая позволяет использовать функции и классы из других 
сборок без необходимости явно указывать ссылки на эти сборки в проекте.
DLL-файлы содержат скомпилированный код, который может быть использован другими приложениями или проектами.

SLR - Он запускает наш код. Тоесть мы даже написали одно слово то В месте со всем подгружается EXE - тоесть нужная библиотека.

......................DOTNET........................

Это набор инструментов и технологий от Microsoft для разработки .NET приложений.
Он включает в себя компилятор, среду выполнения, библиотеку классов и другие компоненты.

BSL Language Server - это инструмент для статического анализа кода

.............. Метаданный ..............
stc - Это мета данные Это
CLS - Это тоже мета данные 
NET является независимой от языка. Это означает, что вести разработку можно на одном из множества языков,
предназначенных для реализаций .NET, например C#, F# и Visual Basic. Чтобы использовать типы и члены библиотек классов,
разработанных для реализаций .NET, не требуется знать их исходный язык и следовать его правилам.
Если вы разрабатываете компоненты, они будут доступны всем приложениям .NET вне зависимости от используемого вами языка.

..............Jet Компилятор.................
"JIT-компилятор - это магия. Вы просто пишете свой код, и ваша программа начинает работать быстрее" - Джон Розенберг,
создатель HotSpot JIT-компилятора для Java Virtual Machine
JIT (Just-In-Time) компиляция - это технология компиляции, которая позволяет генерировать машинный код на лету,
во время выполнения программы.
Это отличается от традиционной компиляции, которая генерирует машинный код заранее, на этапе компиляции исходного кода

conse. RidKei - Бесконечный ввод


 */


using System;
using System.Globalization;

// 2+2


//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int first, second, ans;
//            Console.WriteLine("Insert Num: ");
//            first = Convert.ToInt32(Console.ReadLine()); // Это  явное преобразование.
//            Console.WriteLine("Insert Num2: ");
//            second = Convert.ToInt32(Console.ReadLine());
//            ans = first + second;
//            Console.WriteLine(ans);
//        }
//        }
//    }
//}



//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Program p = new Program(); // Так вызываем экземпляпр класса чтобы вызвать метод класса void Zadacha()
//            p.Zadacha();

//            /* смотри фото учсловия задачи!!!
//             * Пользователь вводит с клавиатуры целое число в диапазоне от 1 до 100.
//             * Если число равное 3 (делиться на 3 без остатка)

//             */

//        }

//        public void Zadacha()
//        {
//            int chislo = Convert.ToInt32(Console.ReadLine()); // Конвертируем в Число наш стринговый ввод ReadLine() тоесть 

//            if (chislo > 100 || chislo < 1)
//            {
//                Console.WriteLine("Error");
//                return;
//            }

//            if (chislo % 3 == 0)
//            {
//                Console.WriteLine("Fizz ");
//            }
//            if(chislo% 5 == 0) {
//                Console.WriteLine("Buzz ");
//            }
//            else if(chislo % 3 != 0 && chislo % 5 != 0) {
//                Console.WriteLine(chislo);
//            }

//        }
//    }
//}


//Задача 2 В Вотсап

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Program p = new Program(); // Так вызываем экземпляпр класса чтобы вызвать метод класса void Zadacha()
//            p.Zadacha();          

//        }
//        public void Zadacha()
//        {
//            Console.WriteLine("Insert two Num: ");
//            double chislo1 = Convert.ToInt32(Console.ReadLine()); // Конвертируем в Число наш стринговый ввод ReadLine() тоесть 
//            double chislo2 = Convert.ToInt32(Console.ReadLine());

//            //    Console.WriteLine(chislo1 * chislo2 /100  );
//            Console.WriteLine("Rezalt: " + chislo1 * chislo2 / 100);
//        }
//    }
//}


// Задача 3

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program(); // Так вызываем экземпляпр класса чтобы вызвать метод класса void Zadacha()
            p.Zadacha();

        }
        public void Zadacha()
        {
            Console.WriteLine("Insert four Num: ");
            int chislo1 = Convert.ToInt32(Console.ReadLine()); // Конвертируем в Число наш стринговый ввод ReadLine() тоесть 
            int chislo2 = Convert.ToInt32(Console.ReadLine());
            int chislo3 = Convert.ToInt32(Console.ReadLine());
            int chislo4 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(chislo1 * chislo2 /100  );
            
            int number = chislo1 * 1000 + chislo2 * 100 + chislo3 * 10 + chislo4;
            Console.WriteLine("Rezalt: " + number);

        }
    }
}
