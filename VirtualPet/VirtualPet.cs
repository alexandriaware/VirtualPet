using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //STATES
        //fields
        protected string petName;
        protected string furColor;
        protected int petAge;
        public int hunger;
        public int thirst;
        public int boredom;
        public int exhaustion;
        protected bool isSick = false;

        //Properties
        public string PetName
        {
            get { return this.petName; }
            set { this.petName = value; }
        }

        public string FurColor { get; set; }
        public int PetAge { get; set; }

        //BEHAVIORS
        //Constructors
        public VirtualPet()
        {

        }
        public VirtualPet(string petName, int petAge, string furColor)
        {
            this.petName = petName;
            this.petAge = petAge;
            this.furColor = furColor;
            this.hunger = 3;
            this.thirst = 3;
            this.boredom = 3;
            this.exhaustion = 1;
        }

        //Methods
        public void Eat()
        {
            if (hunger <= 5 && hunger > 0)
            {
                hunger--;
                Console.WriteLine("You have fed Elsie!");
            }
            else
            {
                Console.WriteLine("Elsie isn't hungry anymore!");
            }
        }
        public void Drink()
        {
            if (thirst <= 5 && thirst > 0)
            {
                thirst--;
                Console.WriteLine("You have watered Elsie!");
            }
            else
            {
                Console.WriteLine("Elsie isn't thirsty right now.");
            }
        }
        public void Play()
        {
            if (exhaustion == 5)
            {
                Console.WriteLine("Elsie is too tired to play right now.");
            }
            else
            {
                boredom--;
                hunger++;
                thirst++;
                exhaustion++;
                Console.WriteLine("You play with Elsie and she trumpets with joy!");
            }
        }
        public void Sleep()
        {
            if (exhaustion == 5)
            {
                exhaustion = 0;
                Console.WriteLine("Elsie settles down to sleep.");
            }
            else
            {
                Console.WriteLine("Elsie doesn't want to nap! She wants to play.");
            }
        }
        public string Stats()
        {
            return "Name: " + petName + "\nAge: " + petAge + "\nFur Color: " + furColor + "\nHunger: " + hunger + "\nThirst: " + thirst + "\nBoredom: " + boredom + "\nTiredness: " + exhaustion;
        }


    }
}
