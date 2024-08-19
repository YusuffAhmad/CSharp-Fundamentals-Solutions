using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_and_using_objects
{
    public class Question11
    {
        public static void Answer()
        {
            Random random = new Random();
            string[] laudatoryPhrases = { "The product is excellent.", "This is a great product.", "I use this product constantly.", 
            "This is the best product from this category." };
            string[] laudatoryStories = { "Now I feel better.", "I managed to change.", "It made some miracle.",
            "I can’t believe it, but now I am feeling great.", "You should try it, too.I am very satisfied." };
            string[] firstNameOfTheAuthor = { "Dayan", "Stella", "Hellen", "Kate" };
            string[] lastNameOfTheAuthor = { "Johnson", "Peterson", "Charls" };
            string[] Cities = { "London", "Paris", "Berlin", "New York", "Madrid" };
            var indexa = random.Next(laudatoryPhrases.Length);
            var randlaudatoryPhrases = laudatoryPhrases[indexa];

            var indexb = random.Next(laudatoryStories.Length);
            var randlaudatoryStories = laudatoryStories[indexb]; 

            var indexc = random.Next(firstNameOfTheAuthor.Length);
            var randfirstNameOfTheAuthor = firstNameOfTheAuthor[indexc]; 

            var indexd = random.Next(lastNameOfTheAuthor.Length);
            var randlastNameOfTheAuthor = lastNameOfTheAuthor[indexd];

            var indexe = random.Next(Cities.Length);
            var randCities = Cities[indexe];

            var message = $"{randlaudatoryPhrases}.{randlaudatoryStories}.{randfirstNameOfTheAuthor}--{randlastNameOfTheAuthor},{randCities}";
            Console.WriteLine(message);
            Console.WriteLine("Press Enter to return to the Main menu");
        }
    }
}
