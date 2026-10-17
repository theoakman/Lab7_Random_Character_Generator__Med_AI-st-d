namespace Lab7_Random_Character_Generator__Med_AI_stöd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Character> myCharacters = new List<Character>();
            var generator = new CharacterGenerator();

            bool isRunning = true; // if this becomes false the program ends
            while (isRunning)
            {

                DisplayMenu();


                string? userInput = Console.ReadLine();


                switch (userInput)
                {
                    case ("1"):

                        CreateCharacter(generator, myCharacters);

                        break;

                    case ("2"):

                        DisplayCharacters(myCharacters);

                        break;

                    case ("3"):

                        DeleteCharacter(myCharacters);

                        break;

                    case ("0"):

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
        public static void CreateCharacter(CharacterGenerator generator, List<Character> myCharacters)
        {

            // Generates new characters thro the CharacterGenerator class and adds then
            // displays the generated values before adding the charater to the myCharacter List
            Console.Clear();

            Console.WriteLine("Genererar en karaktär...");

            Character newCharacter = generator.GenerateCharacter();

            Console.WriteLine($"Name: {newCharacter.Name}");
            Console.WriteLine($"Class: {newCharacter.CharacterClass}");
            Console.WriteLine($"Ability: {newCharacter.SpecialAbility}");
            Console.WriteLine($"Health: {newCharacter.Health} Strength:\t{newCharacter.Strength}\tAgility: {newCharacter.Agility}");

            myCharacters.Add(newCharacter);

            Console.WriteLine("Tryck på knapp för att gå tillbaka");
            Console.ReadKey();
            Console.Clear();
        }
        public static void DisplayCharacters(List<Character> myCharacters)
        {
            Console.Clear();

            if (myCharacters.Count == 0)
            {

                Console.WriteLine("Du har inga sparade karaktärer.");

            }
            else
            {


                // Will display a list of all the currently generated characters that have been generated in the Create Character option

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

        public static void DeleteCharacter(List<Character> myCharacters)
        {
            // AI suggested TryParse() and RemoveAt().
            // I added a while loop to allow multiple deletions
            // and an option to return to the main menu.
            Console.Clear();

            if (myCharacters.Count == 0)
            {

                Console.WriteLine("Det finns inga karaktärer att radera...");

            }

            else // if there are characters in the list the menu for deletion will pop up
            {
                bool isDeleting = true;
                while (isDeleting)
                {
                    Console.Clear();

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
                            isDeleting = false;
                        }

                        else if (choice >= 1 && choice <= myCharacters.Count)
                        {
                            string deletedName = myCharacters[choice - 1].Name;

                            myCharacters.RemoveAt(choice - 1);

                            Console.WriteLine($"{deletedName} har raderats...");
                            Console.WriteLine("Tryck på en knapp för att fortsätta");
                            if (myCharacters.Count != 0)
                            {
                                Console.ReadKey();
                                Console.Clear();
                            }


                            if (myCharacters.Count == 0)
                            {
                                Console.WriteLine("\nDet finns inga karaktärer kvar");
                                Console.WriteLine("Tryck på en knapp för att gå tillbaka till huvudmenyn");
                                Console.ReadKey();
                                Console.Clear();
                                isDeleting = false;
                            }

                        }

                        else
                        {
                            Console.WriteLine("Det finns ingen karaktär under det nummeret...");
                            Console.WriteLine("Tryck på en knapp för att fortsätta");
                            Console.ReadKey();
                            Console.Clear();
                        }

                    }

                    else
                    { // User has typed a invalid input
                        Console.WriteLine("Du måste skriva ett nummer!");
                        Console.WriteLine("Tryck på en knapp för att fortsätta");
                        Console.ReadKey();
                        Console.Clear();

                    }

                }
                Console.Clear();

            }
        }


    }
}
