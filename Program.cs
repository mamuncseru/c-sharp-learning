using System;

using app.Math;

// // Hello World! program
namespace HelloWorld
{
    class Program {         
        static void Main(string[] args)
        {

            // var john = new Person();
            // john.FirstName = "John";
            // john.LastName = "Smith";
            // john.Introduce();

            // Calculator calculator = new Calculator();
            // var result = calculator.Add(1, 2);
            // System.Console.WriteLine(result);
            
            // byte number = 2;
            // int count = 10;
            // float totalPrice = 20.95f;
            // char character = 'A';
            // string firstName = "Morsh";
            // bool isWorking = false;

            // var number = 2;
            // var count = 10;
            // var totalPrice = 20.95f;
            // var character = 'A';
            // var firstName = "Morsh";
            // var isWorking = false;
            
            // Console.WriteLine(number);
            // System.Console.WriteLine(count);
            // System.Console.WriteLine(totalPrice);
            // System.Console.WriteLine(character);
            // System.Console.WriteLine(firstName);
            // System.Console.WriteLine(isWorking);

            // System.Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            // System.Console.WriteLine();

            // int b = 1000;
            // byte i = (byte)b;
            // System.Console.WriteLine(i);

            // var number = "1234";
            // int i = Convert.ToInt32(number);
            // System.Console.WriteLine(i);

            
            // try
            // {
            //     var number = "1234";
            //     byte b = Convert.ToByte(number);
            //     System.Console.WriteLine(b);
            // }
            // catch (System.Exception)
            // {
                
            //     System.Console.WriteLine("The number could not be converted");
            // }
            
            // try
            // {
            //     string str = "true";
            //     bool b = Convert.ToBoolean(str);
            //     System.Console.WriteLine(b);
            // }
            // catch (System.Exception)
            // {
                
            //     System.Console.WriteLine("The number could not be converted");
            // }
            
            // var a = 1;
            // var b = 2;
            // var c = 3;
            // System.Console.WriteLine(a + b * c);

            // var a = 1;
            // var b = 2;
            // var c = 3;
            // System.Console.WriteLine(!(a > b && b > c));

            // int[] numbers = new int[3];
            var numbers = new int[3];
            numbers[0] = 1;

            System.Console.WriteLine(numbers[0]);
            System.Console.WriteLine(numbers[1]);
            System.Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;
            
            System.Console.WriteLine(flags[0]);
            System.Console.WriteLine(flags[1]);
            System.Console.WriteLine(flags[2]);


            var names = new string[3] {"Jack", "John", "Mary" };
            System.Console.WriteLine(names[0]);
        }
    }
}