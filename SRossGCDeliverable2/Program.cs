using System;

namespace SRossGCDeliverable2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string optOne = "sake";
            const string optTwo = "shochu";
            const decimal buffetPrice = 9.99m;
            const decimal optOnePrice = 6.66m;
            const decimal optTwoPrice = 3.33m;

            string emptyGlass = "empty glass";
            decimal totalBill = 0.00m;

            int optOneCount = 0;
            int optTwoCount = 0;
            int emptyGlassCount = 0;
                       
            Console.Write("Welcome to Cherry Blossom Buffet, how many will be joining your party? ");
            string input = Console.ReadLine();
            int guestCount = 0;
            bool isValidGuestCount = (int.TryParse(input, out guestCount)
                                    && guestCount >= 1 && guestCount <=6 );

           

            if (!isValidGuestCount)
            {
                Console.WriteLine("I'm sorry, we're not able to accomodate your party today.");
                Console.ReadLine();
            }
            else //if(isValidGuestCount)
            {
                int[] guests = new int[guestCount - 1];

                Console.Write("Party of " + input + ". Please, right this way."
                                + "Can I start you off with something to drink?"
                                + "Would you like to try our house Sake or Shochu. ");

                Console.WriteLine();

                for (int i = 0; i <= guests.Length; i++)
                {
                    string guest = "Guest " + (i + 1).ToString();
                    Console.Write(guest + " what will you have today? ");
                    string order = Console.ReadLine().ToLower().Trim();

                    switch (order)
                    {
                        case optOne:
                            optOneCount = optOneCount + 1;
                            Console.WriteLine(order + "! Excellent Choice!");
                            Console.WriteLine();

                            decimal subtotal1 = buffetPrice + optOnePrice;
                            totalBill = totalBill + subtotal1;
                            break;


                        case optTwo:
                            optTwoCount = optTwoCount + 1;
                            Console.WriteLine(order + "! Excellent Choice!");
                            Console.WriteLine();

                            decimal subtotal2 = buffetPrice + optTwoPrice;
                            totalBill = totalBill + subtotal2;
                            break;

                        default:
                            emptyGlassCount = emptyGlassCount + 1;
                            Console.WriteLine("Sorry, we're not able to offer that today." 
                                                + "I'll bring you an empty glass if you want to help yourself to the free water dispenser at the buffet. ");
                            Console.WriteLine();

                            decimal subtotal3 = buffetPrice;
                            totalBill = totalBill + subtotal3;
                            break;
                    }
                }

                string printedBill = String.Format("{0:0.##}", totalBill.ToString());

                Console.WriteLine("Ok, I have: ");
                Console.WriteLine("     " + optOneCount + " " + optOne);
                Console.WriteLine("     " + optTwoCount + " " + optTwo);
                Console.WriteLine("     " + emptyGlassCount + " " + emptyGlass);
                Console.WriteLine("Coming right up!");
                Console.WriteLine();
                Console.WriteLine("Your total bill is $" + totalBill + ".");
                Console.WriteLine();
                Console.WriteLine("I hope you enjoy today's buffet selections.");
                Console.WriteLine("Please help yourself, and I'll be right back with your drinks.");
                Console.ReadLine();
            }
        }
    }
}

// Need to account for zero count on either option, 
// and default option before printing total order and bill.