using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet elsie = new VirtualPet("Elsie", 1, "Grey");
            string selection;

            Console.WriteLine("Congratulations on your new pet elephant! You've decided to name her Elsie.");
            ElsieArt();
            Console.WriteLine(elsie.Stats());
            Console.WriteLine("\n");
            Pause();

            do
            {
                Console.WriteLine("What would you like to do with Elsie?");
                Menu();
                selection = Console.ReadLine().Trim();

                if (selection == "1")
                {
                    elsie.Eat();
                    Pause();
                }
                else if (selection == "2")
                {
                    elsie.Drink();
                    Pause();
                }
                else if (selection == "3")
                {
                    elsie.Play();
                    Pause();
                }
                else if (selection == "4")
                {
                    elsie.Sleep();
                    Pause();
                }
                else if (selection == "5")
                {
                    Console.WriteLine("Elsie looks sad and goes to play by herself.");
                    Pause();
                }
                else
                {
                    if (selection != "6")
                    {
                        Console.WriteLine("Please choose something to do with Elsie!");
                    }
                    
                }

            }
            while (selection != "6");

            {
                Console.WriteLine("Thanks for playing!");
                Environment.Exit(0);
            }

        }





        //Methods
        static void Menu()
        {

            Console.WriteLine("1. Feed Elsie");
            Console.WriteLine("2. Water Elsie");
            Console.WriteLine("3. Play with Elsie");
            Console.WriteLine("4. Time for Elsie's nap!");
            Console.WriteLine("5. Do nothing");
            Console.WriteLine("6. Exit");
        }

        static void ElsieArt()
        {
            Console.WriteLine(@"

                               /  \~~~/  \    
                         ,----(     ..    ) 
                        /      \__     __/   
                       /|         (\  |(
                      ^ \   /___\  /\ |   
                         |__|   |__|    ");
        }

        static void Pause()
        {
            System.Threading.Thread.Sleep(2500);
        }
    }
}
