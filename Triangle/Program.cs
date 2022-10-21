using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol;
            int width;

            Console.Write("Please enter a symbol to paint: \n");
            symbol = Console.ReadLine();

            Console.Write("Please enter the width of the triangle:\n");
            width = int.Parse(Console.ReadLine());

            string[][] Triangle = new string[width][];
            
   
            for(int i=0; i<width;i++)
            {
                Triangle[i] = new string[width-i];
            }

            int k = width;
            for(int j = 0; j < width;j++)
            {
                for(int l= k; l > 0; l-- )
                {
                    Triangle[j][l - 1] = symbol;
                    Console.Write(Triangle[j][l - 1].ToString());
                    
                }
                Console.WriteLine();
                k--;
                
            }
            Console.ReadLine();
        }
    }
}
