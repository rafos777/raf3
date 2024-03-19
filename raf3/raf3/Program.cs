string nameToGuess = "rafou";

string userInputName;

// Liste de lettres à ignorer
List<char> lettersToIgnore = new List<char>();

do
{
    Console.WriteLine("Suppose un mot:");
    userInputName = Console.ReadLine();

    // iterons sur toutes les lettres du nom à deviner
    foreach(char guessLetter in nameToGuess)
    {
        // iterons sur toutes les lettres du mot entré par l'utilisateur
        foreach (char userLetter in userInputName)
        {
            // si la lettre n'est pas à ignorer
            //   on teste la lettre et si c'est la meme, on a gagné pour cette lettre

            if ( !lettersToIgnore.Contains(userLetter) )
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
while (nameToGuess != userInputName);

Console.WriteLine("you won");