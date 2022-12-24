using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
           
            Console.WriteLine("\n    Welcome!");
            Console.WriteLine("\n    Enter The Start :");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("\n    Enter The end :");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("\n    List of perfect numbers between " + start + " and " + end + " :");
            for (int i = start; i <= end; i++)
            {
                if (perfect(i))
                    Console.WriteLine(i);
            }
            
        }  
        static bool  perfect (int num ) 
        {
            int sum = 0;
           for(int i = 1; i < num; i++)
           {
                if (num % i == 0)
                    sum+= i;
           }

            if (sum == num)  return true;
               return false;
            
        }
             
                       

           
           

                

             
        
    }   
}
