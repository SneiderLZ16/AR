using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        -----------------------------------------------------------------
        First hello world and data reading 
        -----------------------------------------------------------------
        try
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("!Hello World¡ " + name + ", you're " + age + " years old, keep working hard.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid age");
        }
        finally
        {
            Console.WriteLine("Thank you so much for using me. Have a great day.");
        }
        */

        /*
        -----------------------------------------------------------------
        Cycle for, conditional if/else and Arrays
        -----------------------------------------------------------------
        

        int ave = 0;
        int ma = 0;
        Console.WriteLine("How many ages would you like to average?");
        ma = Convert.ToInt32(Console.ReadLine());
        int[] ages = new int[ma];
        for (int i = 0; i < ages.Length; i++)
        {
            Console.WriteLine("Put the age number " + (i + 1));
            ages[i] = Convert.ToInt32(Console.ReadLine());

            ave = ave + ages[i];
        }
        double average = (ave / ages.Length);
        Console.WriteLine("The average age is " + average);

        if (average < 18)
        {
            Console.WriteLine("Due to a low average you cannot continue");
        }
        else
        {
            Console.WriteLine("You may continue");
        }
        */


        /*
        --------------------------------------------------
        While-Do while and list 
        --------------------------------------------------
        

        List<int> num = new List<int>();
        int op, sum=0;
        

        do
        {
            Console.Write("Put a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            num.Add(n);       
            sum += n;            

            Console.WriteLine("Would you like to add a new one?");
            Console.WriteLine("1) YES   2) NO");
            op = Convert.ToInt32(Console.ReadLine());

        } while (op != 2);

        Console.WriteLine("The total sum is " + sum);
        Console.WriteLine("The amount of sum numbers are: " + num.Count);
        */
    }
}
