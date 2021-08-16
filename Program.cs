using System;
using System.Collections.Generic;

namespace fightingdemo
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Character> Players = new List<Character>(){
                new CloseRange("Mario"),
                new CloseRange("Bowser"),
                new LongRange("Samus")
        };
        Console.WriteLine("Here are your characters! please select ur number corresponding to your character");
        for(int i = 0; i < Players.Count; i++)
        {
            Console.WriteLine($"Type {i} to select");
            Players[i].DisplayStats();
        }   
        //select character
        Console.WriteLine("select character:");
        string choice = Console.ReadLine();
        Character you = Players[Int32.Parse(choice)];
        Console.WriteLine($"you selected {you.Name} as your character!");
        Character enemy = new CloseRange("Link");
        Console.WriteLine("Prepare for battle against Link!");
        Console.WriteLine("Type A to do a weak attack and type B to do a strong attack!");
        while(you.isAlive && enemy.isAlive)
        {
            string input = Console.ReadLine();
            if(input == "A")
            {
            you.WeakAttack(enemy);
            } else {
            you.StrongAttack(enemy);
            }
        }


            // CloseRange Mario = new CloseRange
            // ("Mario");
            // CloseRange Bowser = new CloseRange
            // ("Bowser");
            // LongRange Samus = new LongRange
            // ("Samus");
            // Mario.DisplayStats();
            // Bowser.DisplayStats();
            // Samus.DisplayStats();
            // Samus.WeakAttack(Bowser).StrongAttack
            // (Bowser).WeakAttack(Bowser).StrongAttack
            // (Bowser).StrongAttack(Bowser).
            // StrongAttack(Bowser);
            // string message = Console.ReadLine();
            // Console.WriteLine($"you wrote: {message}");
        }
    }
}
