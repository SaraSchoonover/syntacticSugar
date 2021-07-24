using syntacticSugar;
using System;
using System.Collections.Generic;

namespace syntacticSugar
{
    class Program
    {
        // Expression body definitions let you provide a member's implementation in a very concise, readable form.
        // You can use an expression body definition whenever the logic for any supported member, such as a method or property,
        // consists of a single expression. An expression body definition has the following general syntax:
        // ex: member => expression;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Bug
    {
        /*
            You can declare a typed public property, make it read-only,
            and initialize it with a default value all on the same
            line of code in C#. Readonly properties can be set in the
            class' constructors, but not by external code.
        */
        public string Name { get; } = "";
        public string Species { get; } = "";
        public List<string> Predators { get; } = new List<string>();
        public List<string> Prey { get; } = new List<string>();

        // Convert this readonly property to an expression member
        public string FormalName
        {
            get => $"{this.Name} the {this.Species}";
        }

        // Class constructor
        public Bug(string name, string species, List<string> predators, List<string> prey)
        {
            this.Name = name;
            this.Species = species;
            this.Predators = predators;
            this.Prey = prey;
        }
        // Convert this method to an expression member
        public string PreyList() => string.Join(",", this.Prey);
        

        // Convert this method to an expression member
        public string PredatorList()  => string.Join(",", this.Predators);
       

        // Convert this to expression method
        public string Eat(string food) => this.Prey.Contains(food) ? $"{this.Name} ate the {food}." : $"{this.Name} is still hungry.";
        
    }
}
