namespace Lab7_Random_Character_Generator__Med_AI_stöd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Character> MyCharacters = new List<Character>();
            var Generator = new CharacterGenerator();

            bool isRunning = true;
            while (isRunning)
            {

                DisplayMenu();
                

                string userInput = Console.ReadLine();


                switch (userInput)
                {
                    case ("1"):
                        Console.Clear();

                        Console.WriteLine("Genererar en karaktär...");

                        Character newCharacter = Generator.GenerateCharacter();

                        Console.WriteLine($"Name: {newCharacter.Name}");
                        Console.WriteLine($"Class: {newCharacter.CharacterClass}");
                        Console.WriteLine($"Ability: {newCharacter.SpecialAbility}");
                        Console.WriteLine($"Health: {newCharacter.Health} Strength:\t{newCharacter.Strength}\tAgility: {newCharacter.Agility}");

                        MyCharacters.Add(newCharacter);

                        Console.WriteLine("Tryck på kanpp för att gå tillbaka");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case ("2"):
                        Console.WriteLine("Visar karaktärer");
                        break;

                    case("0"):
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Felaktig input");
                        break;

                }
              

            }







            //CharacterGenerator generator = new CharacterGenerator();

            //Character myCharacter = generator.GenerateCharacter();

            //Console.WriteLine($"Name: {myCharacter.Name}");
            //Console.WriteLine($"Class: {myCharacter.CharacterClass}");
            //Console.WriteLine($"Strength: {myCharacter.Strength}");
            //Console.WriteLine($"Agilty: {myCharacter.Agility}");
            //Console.WriteLine($"Ability: {myCharacter.SpecialAbility}");

        }

        public static void DisplayMenu()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("█▀▄░█▀█░█▀▀                        \r\n█▀▄░█▀▀░█░█                        \r\n▀░▀░▀░░░▀▀▀                        \r\n█▀▀░█░█░█▀█░█▀▄░█▀█░█▀▀░▀█▀░█▀▀░█▀▄\r\n█░░░█▀█░█▀█░█▀▄░█▀█░█░░░░█░░█▀▀░█▀▄\r\n▀▀▀░▀░▀░▀░▀░▀░▀░▀░▀░▀▀▀░░▀░░▀▀▀░▀░▀\r\n█▀▀░█▀▀░█▀█░█▀▀░█▀▄░█▀█░▀█▀░█▀█░█▀▄\r\n█░█░█▀▀░█░█░█▀▀░█▀▄░█▀█░░█░░█░█░█▀▄\r\n▀▀▀ ▀▀▀ ▀ ▀ ▀▀▀ ▀ ▀ ▀ ▀  ▀  ▀▀▀ ▀ ▀");
            Console.WriteLine("-------------------------------------");


            Console.WriteLine("\n\nVälj alternativ");
            Console.WriteLine("1. Generera karaktär");
            Console.WriteLine("2. Visa karaktärerer");
            Console.WriteLine("0. Avsluta program");
        }

    }
}
