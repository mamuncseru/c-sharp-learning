using System;

// // Hello World! program
namespace HelloWorld
{
    class Program {         
        static void Main(string[] args)
        {
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
            
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                System.Console.WriteLine(b);
            }
            catch (System.Exception)
            {
                
                System.Console.WriteLine("The number could not be converted");
            }
        }
    }
}