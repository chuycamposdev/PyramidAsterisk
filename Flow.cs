using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public static class Flow
    {
        public static void PrintAsteriskTree(int rowsToPrint)
        {
            int currentRow = 1;
            bool reduce = false;
            while (currentRow >= 1)
            {

                for (int leftWhiteSpace = currentRow; leftWhiteSpace < rowsToPrint; leftWhiteSpace++)
                {
                    Console.Write(" ");
                }

                Console.Write(new string('*', currentRow + (currentRow - 1)));

                for (int rightWhiteSpace = currentRow; rightWhiteSpace < rowsToPrint; rightWhiteSpace++)
                {
                    Console.Write(" ");
                }

                if (currentRow == rowsToPrint)
                    reduce = true;

                if (!reduce)
                    currentRow++;

                else
                    currentRow--;
                Console.WriteLine();
            }
        }
    }
}
