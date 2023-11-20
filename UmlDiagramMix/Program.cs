using System;
using UmlDiagramMix.BehaviorPatterns;
using static UmlDiagramMix.ThreeDesignPatterns.CreationalPatternsFactoryMethod;

namespace UmlDiagramMix.ThreeDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Behavior Patterns Command 
            Console.WriteLine("\n\n");
            Console.WriteLine("Behavior Pattern ");

            cOMMANDbEHavior BeHaviOr = new cOMMANDbEHavior(); // adlar qariwmasin bele yol lazimdi )) 
            BeHaviOr.RunBehavior();

      

            Console.WriteLine("\n\n");
            // Factory Method 


            Console.WriteLine("Creational Pattern ");

            CreationalPatternRun_ creational  = new CreationalPatternRun_();
            creational.RunFactoryMethod();

            Console.WriteLine("\n\n");

            Console.WriteLine("Structal Patterns ");

            Client_ adapter_ = new Client_();
            adapter_.Adapter_();
        }
    }
}
