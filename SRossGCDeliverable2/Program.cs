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

            Console.WriteLine("Hellurrr and Welcome to MaDea's $9.99 ALL you can eat Buffet... ");
            Console.WriteLine("Where NO carry outs are allowed.");
            Console.WriteLine("Please leave your over-sized purses and man-bags at home..LOL!");
            Console.WriteLine();
            Console.Write("How many in your party? ");
            string input = Console.ReadLine();
            int guestCount = 0;
            bool isValidGuestCount = (int.TryParse(input, out guestCount)
                                    && guestCount >= 1 && guestCount <=6 );

            if (!isValidGuestCount)
            {
                Console.WriteLine("Oh my, I'm sorry we aren't able to accomodate your party size today.");
                Console.ReadLine();
            }
            else
            {
                int[] guests = new int[guestCount - 1];

                
                Console.WriteLine("And what a lovely party of " + input + " you are!");
                Console.WriteLine("Please, right this way.");
                Console.WriteLine();
                Console.WriteLine("Can I start you off with something to drink?");
                Console.WriteLine("All we got today is our house Sake or Shochu. Pick one.");
                Console.WriteLine();

                for (int i = 0; i <= guests.Length; i++)
                {
                    string guest = "Guest " + (i + 1).ToString();
                    Console.Write(guest + " - Sake or Shochu, whatchu having? ");
                    string order = Console.ReadLine().ToLower().Trim();

                    switch (order)
                    {
                        case optOne:
                            optOneCount = optOneCount + 1;
                            Console.WriteLine("Oh, " + order.ToUpper() + " that's a nice choice.");
                            Console.WriteLine();

                            decimal subtotal1 = buffetPrice + optOnePrice;
                            totalBill = totalBill + subtotal1;
                            break;


                        case optTwo:
                            optTwoCount = optTwoCount + 1;
                            Console.WriteLine("Yes, the " + order.ToUpper() + " is a lovely choice and particularly tasty today.");
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

                Console.WriteLine();
                Console.WriteLine("Alright now, go on over to the buffet and help yourself.");
                Console.WriteLine("Please remember to wash your hands and put your mask on first.");
                Console.WriteLine();
                Console.WriteLine("I'll be right back with");
                Console.WriteLine("     " + optOneCount + " " + optOne);
                Console.WriteLine("     " + optTwoCount + " " + optTwo);
                Console.WriteLine("     " + emptyGlassCount + " " + emptyGlass);
                Console.WriteLine();
                Console.WriteLine("Your total bill is $" + totalBill + ".");
                Console.WriteLine("We accept cash, debit, credit, EBT, Amazon gift cards, and tipping the waiter is strongly encouraged.");
                Console.WriteLine("Thank You very much!");
                Console.ReadLine();
            }
        }
    }
}