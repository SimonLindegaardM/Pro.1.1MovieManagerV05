using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            
            string titel = "Joker";
            string director = "Todd Phillips";
            string MC = "Joaquin Phoenix";
            double rating = 8.6;
            int year = 2019; 
            string genre = "Drama";
            int durationInMinutes = 122;


            System.Console.WriteLine(titel);
            System.Console.WriteLine(director);
            System.Console.WriteLine(MC);
            System.Console.WriteLine(rating);
            System.Console.WriteLine(year);
            System.Console.WriteLine(genre);
            System.Console.WriteLine(durationInMinutes + 10);
        System.Console.WriteLine($"Title: {titel}  Year: {year} Main cast: {MC} Genre: {genre} Duration in minutes: {durationInMinutes} Rating: {rating}");

            // The LAST line of code should be ABOVE this line
        }
    }
}
