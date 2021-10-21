using System;
using System.Collections.Generic;

namespace Blockbuster_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create your classes first - starting with the Movie class
            //Keep in mind which methods would need to be different per object
            //Use a Store class to run the methods and create the lists - similar to the movie walkthrough we did earlier
            //Use Program to test your stuff per item!  Don't get hung up on a method doing EVERYTHING.
            //DVD dvd = new DVD();
            //VHS vhs = new VHS();

            Blockbuster bb = new Blockbuster();
            
            
            Console.WriteLine(bb.Movies[3]);
            Console.WriteLine();
            Console.WriteLine(bb.Predator.Title);
            bb.PrintScenes(bb.Predator.SceneList);
            Console.WriteLine();
            bb.Casablanca.Play();

            bb.ToyStory.Play();
            Console.WriteLine();
            bb.PrintMovies();


            bb.CheckOut();
        }
    }
}
