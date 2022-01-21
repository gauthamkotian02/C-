# C-file:///C:/Users/MCA/Documents/IPMsg/AutoSave/1632212070923_CSharp_Record_Final.pdf
c# programs 
﻿using System;

namespace Excercise
{
    class BinaryTriangle
    {
        static void Main(string[] args)
        {
            int number, digit = 1;

            Console.Write("\nEnter the no of lines:");
            number =Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int space = number - i; space > 0; space--)
                {
                    Console.Write("");
                 }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(digit + "");
                    digit = (digit == 1)?0:1;
                }
                Console.Write("\n");
            }
        }

    }
}
<br>
![Screenshot 2022-01-21 120754 - Copy](https://user-images.githubusercontent.com/98144065/150481126-cd0004d1-e965-4ae8-8cec-18c850604e59.png)
