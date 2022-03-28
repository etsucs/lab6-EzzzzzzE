using System;
namespace Homwork6 { 
public class Homework6 
{  
    public static void ShowCharacter(string str, int n)
   {
       Console.WriteLine(str[n-1]); 
   }
   public static double CalculateRetail(double cost, double rate)
   {
       return ((1+(0.01*rate))*cost);
   }
   public static double Celsius(double f)
   {
       return ((5*(f - 32))/9);
   }
   public static bool IsPrime(int g)
   {
       if(g <= 1) return false;
       else
       {
           for(int i = 2; i*i < g; ++i) {
               if(g%i == 0) return false;
           }
       return true;
       }
   }
   public static void Main(string[] args) {
       Console.WriteLine("Enter a word.");
       string str = (Console.ReadLine());
       Console.WriteLine("Enter the number of the character you want to know.");
       int n = Int32.Parse(Console.ReadLine ());
        ShowCharacter(str, n);
        Console.WriteLine("\nEnter whole sale cost: ");
        double cost = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nEnter the markup percentage: ");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nRetail Price is $"+ Math.Round(CalculateRetail(cost,rate),2));
        Console.WriteLine("\nEnter temperature fahrenheit: ");
        double f = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nCelsius: "+ Math.Round(Celsius(f),2));
        Console.WriteLine("\nWhat is your number ");
        int g = Int32.Parse(Console.ReadLine());
         if(IsPrime(g))
        Console.WriteLine(g + " is a prime number");
        else
        Console.WriteLine(g + " is not a prime number");
        Console.WriteLine("\nWhat is your number ");
        int p = Int32.Parse(Console.ReadLine());
         if(IsPrime(p))
        Console.WriteLine(p + " is a prime number");
        else
        Console.WriteLine(p + " is not a prime number");

   }
}
}



