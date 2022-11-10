// C# program to convert time from 24 hour
// to 12 hour format

using System;

class GFG
{
    static void Convert12(string str1)
    {
        // Get Hours
        int h1 = (int)str1[0] - '0';
        int h2 = (int)str1[1] - '0';
        //str = Console.ReadLine();

        int hh = h1 * 10 + h2;
        //hh %= 12;

        string Meridien;
        if (hh < 12)
        {
            Meridien = "AM";
        }
        else
            Meridien = "PM";

        hh %= 12;

        if (hh == 0)
        {
            Console.Write("12");
            //Printing minutes and seconds
            for (int i = 2; i < 8; ++i)
            {
                Console.Write(str1[i]);
            }

        }
        else
        {
            Console.Write(hh);
            for (int i = 2; i < 8; ++i)
            {
                Console.Write(str1[i]);
            }

        }

        Console.WriteLine(" " + Meridien);
    }

    static void convert12(string str)
    {
        // Get Hours
        int h1 = (int)str[0] - '0';
        int h2 = (int)str[1] - '0';

        int hh = h1 * 10 + h2;
        //int hhh = h2 * 10 + h1;

        // Finding out the Meridien of time
        // ie. AM or PM
        string Meridien;
        if (hh <= 12)
        {
            Meridien = "AM";
        }
        else
            Meridien = "PM";

        hh %= 12;

        // Handle 00 and 12 case separately
        if (hh == 0)
        {
            Console.Write("12");

            // Printing minutes and seconds
            for (int i = 2; i < 8; ++i)
            {
                Console.Write(str[i]);
            }
        }
        else
        {
            Console.Write(hh);
            // Printing minutes and seconds
            for (int i = 2; i < 8; ++i)
            {
                Console.Write(str[i]);
            }
        }

        // After time is printed
        // cout Meridien
        Console.WriteLine(" " + Meridien);
    }

    //Driver code
    public static void Main()
    {

        // 24 hour format
        Console.WriteLine("24 hours format:");
       string str= Convert.ToString(Console.ReadLine());
       // string str = "23:00:00 ";
        convert12(str);
        Console.WriteLine("Enter the 12 hours format:");
        string str1 = Convert.ToString(Console.ReadLine());
        Convert12(str1);
        
    }
}