using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Input and Print Number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered: " + number);
            #endregion
            
            #region Value Type Assignment and Modification
            int val1 = 10;
            int val2 = val1; 
            val2 += 5;        
            Console.WriteLine("Value1 "+val1+" "+ "Value2 "+ val2);
            //val1 unchanged because value types store copies of data.
            #endregion

            #region Reference Type Assignment and Modification 
            string str1 = "Youssef";
            string str2 = str1; 
            str2 = " Essam";  
            Console.WriteLine($"Str1: {str1}, Str2: {str2}");   
            // Modifying str2 creates a new string
            

            #endregion




        }
    }
}