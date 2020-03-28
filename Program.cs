using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string slovo = "dotnet";
            string otvet ="";
            int popitka = 5; 


            for (int i = 1; i <= popitka; i++)
            {
                System.Console.WriteLine("Vvedite slovo: ");
                otvet = Console.ReadLine();
                if(otvet == slovo)
                {
                    System.Console.WriteLine("Ura !!! Vi otgadali !!! s " + i + " -y popitki");
                    
                    break;

                }else{
                    System.Console.WriteLine("Voi NE otgadali !!!");
                }
            }

            int a = 5, b = 11;
            int sum = 0;
            for (int i = a; i <= b; i++){
                sum = sum + i;
            }
            System.Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}