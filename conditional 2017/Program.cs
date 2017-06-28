using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional_2017
{
    class Program
    {
        static void Main(string[] args)

        {
            //ask user how much was bill
            //Console.WriteLine("How much was you bill?");
            //double bill = double.Parse(Console.ReadLine());
            //if (bill >= 50)
            //{
            //    Console.WriteLine("You get 10% off of your bill");

            //}
            //else
            //{
            //    Console.WriteLine("You get 5% off of your bill");
            //}

            //Console.WriteLine("How many people are in your party");
            //int numberOfPeople = int.Parse(Console.ReadLine());
            //double costPerPerson = bill / numberOfPeople;
            //Console.WriteLine("Each person paid $" + costPerPerson);


            //Console.WriteLine("What is the name on the reservation");
            //string reserveName = Console.ReadLine();


            Console.WriteLine("Thank you for eating at Jerome's Grub Shack!");
            Console.WriteLine("What is your total bill?");
            double billTotal = double.Parse(Console.ReadLine());
            double discountTen = (billTotal - (billTotal * .10d));
            double discountFive = (billTotal - (billTotal * .05));
            double billSplit;

            Console.WriteLine("How many people are in your Party?");
            int numberOfPeople = int.Parse(Console.ReadLine());

            if (billTotal >= 50)
            {
                Console.WriteLine("You will get a ten percent discount!");
                Console.WriteLine("Your total with your discount: $" + discountTen);
                billSplit = discountTen / numberOfPeople;
                Console.WriteLine("Each person in your party will pay $" + billSplit);
            }
            else
            { 
            Console.WriteLine("You will get a five percent discount!");
                billSplit = discountFive / numberOfPeople;

                Console.WriteLine("Your total with your discount: $" + discountFive);
                Console.WriteLine("Each person in your party will pay $" + billSplit);
               

            }



            }

    }




}
       