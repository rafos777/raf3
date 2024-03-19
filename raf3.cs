using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameToGuess = "rafou";
            Console.WriteLine("Suppose un mot:");
            string userInputName = Console.ReadLine();

            // Liste de lettres à ignorer
            List<char> lettersToIgnore = new List<char>();
            lettersToIgnore.Add('.');
            do
            {
                for(int iGuess=0; iGuess<nameToGuess.Length; iGuess++)
                {
                    char guessLetter = nameToGuess[iGuess];

                    Console.WriteLine($"Name to guess[{iGuess}] = {guessLetter}");
                    
                    for (int iUserIndex=0; iUserIndex<userInputName.Length; iUserIndex++)
                    {
                        char userLetter = userInputName[iUserIndex];
                        
                        Console.WriteLine(lettersToIgnore.Count);
                        // Chercher si cette lettre n'est pas dans la liste des lettres à ignorer
                        for(int iIgnoreIndex=0;iIgnoreIndex < lettersToIgnore.Count ; iIgnoreIndex++)
                        {
                            Console.WriteLine($"lettersToIgnore.Count = {lettersToIgnore.Count}, iIgnoreIndex = {iIgnoreIndex}");

                            char letterToIgnore = lettersToIgnore[iIgnoreIndex];

                            Console.WriteLine($"User input[{iUserIndex}] = {userLetter}");
                            Console.WriteLine($"Letter to ignore [{iIgnoreIndex}] = {letterToIgnore}");
                            if (userLetter!=letterToIgnore) 
                            {
                                Console.WriteLine("D");
                                if( userLetter == guessLetter)
                                {
                                    Console.WriteLine("E");
                                    Console.WriteLine($"Letter {userLetter} correct!");
                                    // Ajouter cette lettre à une liste de lettres à ignorer

                                    lettersToIgnore.Add(userLetter);
                                }
                            }
                        }
                    }      
                }
                Console.WriteLine("Suppose un mot:2");
                userInputName = Console.ReadLine();

            }
            while (nameToGuess != userInputName);
            Console.WriteLine("you won");
        }
    }
}