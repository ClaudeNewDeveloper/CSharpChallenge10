using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerranktest10
{
    class Program
    {

        public static  Stack<int> stackOfBinaryNumbers = new Stack<int>();

        public static void ConvertDecimalToBinary(int n)
        {
            int remainder = -1;
            int quotient = n;
          
        while (quotient > 0 )
        {
            remainder = quotient % 2;
            
            quotient = quotient / 2;
            
            stackOfBinaryNumbers.Push(remainder);
        }
        
         int[] arrayOfDigits  = new int[stackOfBinaryNumbers.Count];
        
        int maxNumberOfConsecutiveOnes = 0;
        int maxNumberOfConsecutiveDigitOnes = maxNumberOfConsecutiveOnes;
        
            Console.WriteLine("displaying the binary: ");
        
        for (int i = 0; i < stackOfBinaryNumbers.Count; i++)
        {  
            arrayOfDigits[i] = (int) stackOfBinaryNumbers.ElementAt(i);
            Console.Write(arrayOfDigits[i]);
            
        }
        
            Console.WriteLine();
        
          //  Console.WriteLine("digit in array ");
        for(int i = 0; i < arrayOfDigits.Length ; i++)
        { 
           if(arrayOfDigits[i] == 1) 
               maxNumberOfConsecutiveOnes++;
           
           else if(maxNumberOfConsecutiveDigitOnes < maxNumberOfConsecutiveOnes)
           {
               maxNumberOfConsecutiveDigitOnes = maxNumberOfConsecutiveOnes;
               maxNumberOfConsecutiveOnes = 0;
           }
           
           else 
               maxNumberOfConsecutiveOnes = 0;
               
        }
        
          if(maxNumberOfConsecutiveDigitOnes < maxNumberOfConsecutiveOnes)
           
               maxNumberOfConsecutiveDigitOnes = maxNumberOfConsecutiveOnes;
             
           
        
        
           Console.WriteLine();
           Console.WriteLine("the maximum number of consecutive 1's is: " + maxNumberOfConsecutiveDigitOnes);

           Console.WriteLine();
        
    }
        
        static void Main(string[] args)
        {
            string value = "Dot Net Perls";

            // Use ToCharArray to convert string to array.
            char[] array = value.ToCharArray();

           // array = Convert.ToChar(test);

            Console.Write("Please, enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n != 0)
            {
                ConvertDecimalToBinary(n);
            }

            Console.ReadKey();
        }
    }
}
