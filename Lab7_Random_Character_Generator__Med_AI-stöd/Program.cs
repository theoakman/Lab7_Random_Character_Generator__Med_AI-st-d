using Microsoft.VisualBasic;
using System.Reflection.Emit;

namespace Lab7_Random_Character_Generator__Med_AI_stöd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Character> myCharacters = new List<Character>();
            var Generator = new CharacterGenerator();

            bool isRunning = true; // if this becomes false the program ends
            while (isRunning)
            {

                DisplayMenu();
                

                string? userInput = Console.ReadLine();


                switch (userInput)
                {
                    case ("1"):

                        CreateCharacter(Generator, myCharacters);

                        break;

                    case ("2"):

                        DisplayCharacters(myCharacters);

                        break;

                    case ("3"):

                        DeleteCharacter(myCharacters);

                        break;

                    case("0"):

                        isRunning = false;

                        break;

                    default:

                        Console.Clear();
                        Console.WriteLine("Felaktig input");

                        break;

                }
            }
        }

        public static void DisplayMenu()
        {
            // Just the text that displays the main menu
            // This method will be called every time a action is complete


            Console.WriteLine("-------------------------------------");
            Console.WriteLine("█▀▄░█▀█░█▀▀                        \r\n█▀▄░█▀▀░█░█                        \r\n▀░▀░▀░░░▀▀▀                        \r\n█▀▀░█░█░█▀█░█▀▄░█▀█░█▀▀░▀█▀░█▀▀░█▀▄\r\n█░░░█▀█░█▀█░█▀▄░█▀█░█░░░░█░░█▀▀░█▀▄\r\n▀▀▀░▀░▀░▀░▀░▀░▀░▀░▀░▀▀▀░░▀░░▀▀▀░▀░▀\r\n█▀▀░█▀▀░█▀█░█▀▀░█▀▄░█▀█░▀█▀░█▀█░█▀▄\r\n█░█░█▀▀░█░█░█▀▀░█▀▄░█▀█░░█░░█░█░█▀▄\r\n▀▀▀ ▀▀▀ ▀ ▀ ▀▀▀ ▀ ▀ ▀ ▀  ▀  ▀▀▀ ▀ ▀");
            Console.WriteLine("-------------------------------------");

            // The menu choices, just the text, the actual switch case that contols the menu is in main

            Console.WriteLine("\n\nVälj alternativ");
            Console.WriteLine("1. Generera karaktär");
            Console.WriteLine("2. Visa karaktärerer");
            Console.WriteLine("3. Radera karaktär");
            Console.WriteLine("0. Avsluta program");


        }
        public static void CreateCharacter(CharacterGenerator Generator, List<Character> myCharacters)
        {

            // Generates new characters thro the CharacterGenerator class and adds then
            // displays the generated values before adding the charater to the myCharacter List
            Console.Clear();

            Console.WriteLine("Genererar en karaktär...");

            Character newCharacter = Generator.GenerateCharacter();

            Console.WriteLine($"Name: {newCharacter.Name}");
            Console.WriteLine($"Class: {newCharacter.CharacterClass}");
            Console.WriteLine($"Ability: {newCharacter.SpecialAbility}");
            Console.WriteLine($"Health: {newCharacter.Health} Strength:\t{newCharacter.Strength}\tAgility: {newCharacter.Agility}");

            myCharacters.Add(newCharacter);

            Console.WriteLine("Tryck på kanpp för att gå tillbaka");
            Console.ReadKey();
            Console.Clear();
        }
        public static void DisplayCharacters(List<Character> myCharacters)
        {
            // Will display a list of all the currently generated characters that have been generated in the Create Character option
            Console.Clear();

            Console.WriteLine("Dina karaktärer");

            foreach (var character in myCharacters)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"Name: {character.Name}");
                Console.WriteLine($"Class: {character.CharacterClass}");
                Console.WriteLine($"Ability: {character.SpecialAbility}");
                Console.WriteLine($"Stats\nHealth: {character.Health}\tStrength:{character.Strength}\tAgility: {character.Agility}");
                Console.WriteLine("-------------------------------------------");
            }

            Console.WriteLine("Tryck på kanpp för att gå tillbaka");
            Console.ReadKey();
            Console.Clear();
        }

        public static void DeleteCharacter(List<Character> myCharacters)
        {
            Console.Clear();
            bool isdeleteing = true;
            while (isdeleteing)
            {

                if (myCharacters.Count < 1) // Checks if there are any character in the list
                {
                    Console.WriteLine("Det finns inga karatärer att radera...");
                    Console.WriteLine("Tryck på en knapp för att gå tillbaka till huvudmenyn");
                    Console.ReadKey();
                    break;
                }
                else // if there are characters in the list the menu for deletion will pop up
                {

                    int i = 1;

                    Console.WriteLine("Vem vill du radera?");
                    Console.WriteLine("Skriv in motsvarande nummer och tryck enter");
                    Console.WriteLine("Skriv 0 för att gå tillbaka till huvudmenyn");

                    // Displays all the created characters names in a list with a coresponding number
                    foreach (var character in myCharacters)
                    {
                        Console.WriteLine($"{i}. {character.Name}");
                        i++;
                    }

                    // Deletes a the character from the list when writing their displayed number.
                    // The user input get converted to the correct Chracter list index and then removes that character from the list.
                    // If the input dosent match a coresponding character the program will notify that
                    // When the user input is 0 this method will end

                    if (int.TryParse(Console.ReadLine(), out int choice))
                    { // User has typed a valid number

                        if (choice == 0)
                        {
                            isdeleteing = false;
                        }
                        
                        else if (choice >= 1 && choice <= myCharacters.Count)
                        {
                            string deletedName = myCharacters[choice - 1].Name;

                            myCharacters.RemoveAt(choice - 1);

                            Console.WriteLine($"{deletedName} har raderats...");
                            Console.WriteLine("Tryck på en knapp för att fortsätta");
                            Console.ReadKey();
                            Console.Clear();

                        }

                        else
                        {
                            Console.WriteLine("Det finns inte en karatär under det nummeret...");
                        }

                    }

                    else
                    { // User has typed a invalid input
                        Console.WriteLine("Du måste skriva ett nummer!");
                    }

                }
            }
            Console.Clear();
        }


    }
}
