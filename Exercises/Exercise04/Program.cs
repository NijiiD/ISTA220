using System;
using System.Runtime.CompilerServices;

namespace Exercise04
{
    public class Cat
    {
        public string name;
        public string sound;
        public string ability;

        public Cat()
        {
            name = "No Name";
            sound = "No sound";
            ability = "No ability";
        }
        public Cat(string name = "No name")
        {

        }
        public void MakeCatSound()
        {
            Console.WriteLine("{0} is a cat and says meow", name);
        }
        public void CatAbility()
        {
            Console.WriteLine("{0} can jump high", name);
        }

    }
    public class Dog
    {
       public string name;
       public string sound;
       public string ability;

       public Dog()
       {
           name = "No Name";
           sound = "No sound";
           ability = "No ability";
       }
       public Dog(string sound = "No sound")
       {

       }
       public void MakeDogSound()
       {
         Console.WriteLine("{0} is a dog and says woof", name);
       }
       public void DogAbility()
       {
          Console.WriteLine("{0} can bite", name);
       }

    }
    public class Horse
    {
        public string name;
        public string sound;
        public string ability;

        public Horse()
        {
            name = "No Name";
            sound = "No sound";
            ability = "No ability";
        }
        public Horse(string sound = "No sound")
        {

        }
        public void MakeHorseSound()
        {
            Console.WriteLine("{0} is a horse and neighs", name);
        }
        public void HorseAbility()
        {
            Console.WriteLine("{0} can run fast", name);
        }

    }
    public class Cow
    {
        public string name;
        public string sound;
        public string ability;

        public Cow()
        {
            name = "No Name";
            sound = "No sound";
            ability = "No ability";
        }
        public Cow(string sound = "No sound")
        {

        }
        public void MakeCowSound()
        {
            Console.WriteLine("{0} is a cow and moos", name);
        }
        public void CowAbility()
        {
            Console.WriteLine("{0} can make milk", name);
        }

    }

    class poo
        {
            static void Main(string[] args)
            {
            Cat cat1 = new Cat()
            {
               name = "Whiskers"
            };
            Cat cat2 = new Cat()
            {
               name = "Snowball"
            };
            Cat cat3 = new Cat()
            {
               name = "GrumpyCat"
            };
            Cat cat4 = new Cat()
            {
               name = "Jake"
            };
            
            Dog dog1 = new Dog()
            {
                name = "Rover"
            };
            Dog dog2 = new Dog()
            {
                name = "Fred"
            };
            Dog dog3 = new Dog()
            {
                name = "Goofy"
            };
            Dog dog4 = new Dog()
            {
                name = "Pluto"
            };
            Horse horse1 = new Horse()
            {
                name = "Seabiscut"
            };
            Horse horse2 = new Horse()
            {
                name = "Seattle Slew"
            };
            Horse horse3 = new Horse()
            {
                name = "Man o' War"
            };
            Horse horse4 = new Horse()
            {
                name = "Secretariat"
            };
            Cow cow1 = new Cow()
            {
                name = "Bessy"
            };
            Cow cow2 = new Cow()
            {
                name = "Clarabelle"
            };
            Cow cow3 = new Cow()
            {
                name = "Lady"
            };
            Cow cow4 = new Cow()
            {
                name = "Priscilla"
            };




            cat1.MakeCatSound();
            cat1.CatAbility();
            cat2.MakeCatSound();
            cat2.CatAbility();
            cat3.MakeCatSound();
            cat3.CatAbility();
            cat4.MakeCatSound();
            cat4.CatAbility();
            dog1.MakeDogSound();
            dog1.DogAbility();
            dog2.MakeDogSound();
            dog2.DogAbility();
            dog3.MakeDogSound();
            dog3.DogAbility();
            dog4.MakeDogSound();
            dog4.DogAbility();
            horse1.MakeHorseSound();
            horse1.HorseAbility();
            horse2.MakeHorseSound();
            horse2.HorseAbility();
            horse3.MakeHorseSound();
            horse3.HorseAbility();
            horse4.MakeHorseSound();
            horse4.HorseAbility();
            cow1.MakeCowSound();
            cow1.CowAbility();
            cow2.MakeCowSound();
            cow2.CowAbility();
            cow3.MakeCowSound();
            cow3.CowAbility();
            cow4.MakeCowSound();
            cow4.CowAbility();

            }



    }
    

}
