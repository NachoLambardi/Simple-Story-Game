using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program Short Funny Story
      Author: Nacho Lambardi
      */


      // Let the user know that the program is starting:


      // Give the Mad Lib a title:
      string title = "Short Funny Story";

      Console.WriteLine(title);
      // Define user input and variables:


      // The template for the story:
      Console.WriteLine("This game is Starting!");
      
      /* Main Name Variable*/
      
      Console.Write("Enter your main character name: ");
      String mainName = Console.ReadLine();
      
      // Favourite Color//
      Console.Write("What is your favourite color?");
      String firstColor = Console.ReadLine();
      
      // Feelings //
      Console.Write("How do you feel?");
      String feeling = Console.ReadLine();
      
      // Music types //
      Console.Write("Which kind of music do you prefer?");
      String musicType = Console.ReadLine();
      
      // Verb 1 //
      Console.Write("Insert the verb you prefer: ");
      String verb1 = Console.ReadLine();
      
      // Place 1 //
      Console.Write("Where do you prefer to live? ");
      String place1 = Console.ReadLine();
      
      // Music Instrument //
      Console.Write("Which music instrument do you like? ");
      String musicInstrument = Console.ReadLine();
      
      // User Selection List // 
      Console.WriteLine("Please choose one of each option: ");
      Console.Write("A animal: ");  
      String animal = Console.ReadLine();
      
      Console.Write("A food: ");  
      String food = Console.ReadLine();
      
      Console.Write("A fruit: ");  
      String fruit = Console.ReadLine();
      
      Console.Write("A superhero: ");  
      String superhero = Console.ReadLine();
      
      Console.Write("A country: ");  
      String country = Console.ReadLine();
      
      Console.Write("A dessert: ");  
      String dessert = Console.ReadLine();
      
      Console.Write("A year: ");  
      String year = Console.ReadLine();
      
      
      
      string story = $"This morning {mainName} woke up feeling {firstColor}. 'It is going to be a {feeling} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb1} to the rhythm of the {place1}, which made all the {fruit}s very {musicType}. Concerned, {mainName} texted {superhero}, who flew {mainName} to {country} and dropped {mainName} in a puddle of frozen {dessert}. {mainName} woke up in the year {year}, in a world where {musicInstrument}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}
