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




        /*-------------------------------------------------
        --------------------ATM----------------------------
        --------------------------------------------------*/

        int bl = 1000000, wt, dp, db=0,ad, op = 0, py=0;

        do
        {
            try
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("---Welcome to the ATM, please choose an option.---");
                Console.WriteLine("1) Check balance");
                Console.WriteLine("2) Withdraw money");
                Console.WriteLine("3) Deposit money");
                Console.WriteLine("4) Advanced banking");
                Console.WriteLine("5) Pay debt");
                Console.WriteLine("6) Exit");
                Console.WriteLine("--------------------------------------------------");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Your balance is: " + bl);
                        break;
                    case 2:
                        Console.WriteLine("How much would you like to withdraw?");
                        wt = Convert.ToInt32(Console.ReadLine());
                        if (wt > bl)
                        {
                            Console.WriteLine("Insufficient balance");
                        }
                        else
                        {
                            bl -= wt;
                            Console.WriteLine("You have withdrawn: " + wt);
                            Console.WriteLine("Your new balance is: " + bl);
                        }
                        break;
                    case 3:
                        Console.WriteLine("How much would you like to deposit?");
                        dp = Convert.ToInt32(Console.ReadLine());
                        bl += dp;
                        Console.WriteLine("You have deposited: " + dp);
                        Console.WriteLine("Your new balance is: " + bl);
                        break;
                    case 4:
                        Console.WriteLine("How much would you like to reqeuest in advanced?");
                        ad = Convert.ToInt32(Console.ReadLine());
                        db += ad;
                        bl += ad;
                        Console.WriteLine("You have requested: " + ad);
                        Console.WriteLine("Your new balance is: " + bl);
                        Console.WriteLine("Your total debt is: " + db);
                        break;
                    case 5:
                        if (db == 0)
                        {
                            Console.WriteLine("You don't have any debt");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Your total debt is: " + db);
                            Console.WriteLine("How much would you like to pay?");  
                            py = Convert.ToInt32(Console.ReadLine());
                            if (py > bl)
                            {
                                Console.WriteLine("Insufficient balance");
                            }
                            else if (py > db)
                            {
                                Console.WriteLine("The amount exceeds your debt");
                            }
                            else
                            {
                                db -= py;
                                bl -= py;
                                Console.WriteLine("You have paid: " + py);
                                Console.WriteLine("Your new balance is: " + bl);
                                Console.WriteLine("Your remaining debt is: " + db);
                            }
                        }
                        break;
                    case 6:
                        Console.WriteLine("Thank you for using our ATM, have a great day.");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
            }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid option");
            }
        }while (op != 6);

    }
}
