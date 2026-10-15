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

            bool isRunning = true;
            while (isRunning)
            {

                DisplayMenu();
                

                string userInput = Console.ReadLine();


                switch (userInput)
                {
                    case ("1"):

                        CreateCharacter(Generator, myCharacters);

                        break;

                    case ("2"):

                        DisplayCharacters(myCharacters);

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


    }
}
