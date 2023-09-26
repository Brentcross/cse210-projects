using System;
using System.Collections.Generic;

namespace ScriptureMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            var johnReference = new ScriptureReference("John", 3, "16");
            var johnScriptureText = "For God so loved the world, that he gave his only Son,";
            var johnScripture = new Scripture(johnScriptureText, johnReference);

            var almaReference = new ScriptureReference("Alma", 32, "21-22");
            var almaScriptureText = 
                "21 And now as I said concerning faith—faith is not to have a perfect knowledge of things; " +
                "therefore if ye have faith ye hope for things which are not seen, which are true.\n" +
                "22 And now, behold, I say unto you, and I would that ye should remember, that God is merciful unto all " +
                "who believe on his name; therefore he desireth, in the first place, that ye should believe, yea, even on his word.";
            var almaScripture = new Scripture(almaScriptureText, almaReference);

            var helemanReference = new ScriptureReference("Helaman", 5, "12");
            var helemanScriptureText = 
                "12 And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, " +
                "that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, " +
                "yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf " +
                "of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.";
            var helemanScripture = new Scripture(helemanScriptureText, helemanReference);

            List<Scripture> scriptures = new() { johnScripture, almaScripture, helemanScripture };

            while (true)
            {

                Console.WriteLine("Select a scripture:");
                for (int i = 0; i < scriptures.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {scriptures[i].Reference}");
                }

                int selection;
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out selection) && selection > 0 && selection <= scriptures.Count)
                        break;
                    Console.WriteLine("Invalid choice. Please select again.");
                }

                Scripture chosenScripture = scriptures[selection - 1];

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(chosenScripture);
                    Console.WriteLine("\nPress Enter to hide a word in the scripture, when completed type 'next' to choose another scripture, or type 'quit' to exit.");

                    string input = Console.ReadLine();
                    if (input?.ToLower() == "quit")
                        return;
                    if (input?.ToLower() == "next")
                        break;

                    chosenScripture.HideRandomWord();
                }
            }
        }
    }
}
