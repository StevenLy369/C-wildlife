using System;
using System.Collections.Generic;
using Models;

namespace Tracker{
    public class Program{
        public static void Main(){
            Animal bear = new Animal("Bob", "Brown Bear", "Brown", "Bear", 3);
            Animal wolf = new Animal("Rob", "Grey Wolf", "Grey", "Wolf" , 2);
            Animal pig = new Animal("Pob", "Pink pig", "Pink","Pig", 1 );









            List <Animal> AnimalList = new List <Animal>(){bear, wolf,pig};

            pig.SetAge(19);

            foreach(Animal tracked in AnimalList ){

                Console.WriteLine("#####################");
                Console.WriteLine(tracked.GetName());
                Console.WriteLine(tracked.GetBreed());
                Console.WriteLine(tracked.GetColor());
                Console.WriteLine(tracked.GetAge());
                Console.WriteLine(Animal.MakePoopNoise("poo poo"));

            }
            
        }
    }
}