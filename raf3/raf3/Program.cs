string nameToGuess = "r";

string userInputName;

// Liste de lettres à ignorer
List<char> lettersToIgnore = new List<char>();

do
{
    Console.WriteLine("Suppose un mot:");
    userInputName = Console.ReadLine();

    // iterons sur toutes les lettres du nom à deviner
    for (int i = 0; i < nameToGuess.Length; i++)
    {
        char guessLetter = nameToGuess[i];

        // iterons sur toutes les lettres du mot entré par l'utilisateur
        for (int j = 0; j < userInputName.Length; j++)
        {
            char userLetter = userInputName[j];

            // Chercher si cette lettre n'est pas dans la liste des lettres à ignorer
            for (int k = 0; k < (lettersToIgnore.Count+1); k++)
            {
                char letterToIgnore = lettersToIgnore[k];

                // si on ignore pas
                if (userLetter != letterToIgnore)
                {
                    // si c'est la meme
                    if (userLetter == guessLetter)
                    {
                        // on a gagné une lettre!
                        Console.WriteLine($"Letter {userLetter} correct!");

                        // Ajouter cette lettre à une liste de lettres à ignorer
                        lettersToIgnore.Add(userLetter);
                    }
                }
            }
        }
    }
}
while (nameToGuess != userInputName);

Console.WriteLine("you won");