namespace Lab7_Random_Character_Generator__Med_AI_stöd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Character> MyCharacters = new List<Character>();

            bool isRunning = true;
            while (isRunning)
            {

            
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("█▀▄░█▀█░█▀▀                        \r\n█▀▄░█▀▀░█░█                        \r\n▀░▀░▀░░░▀▀▀                        \r\n█▀▀░█░█░█▀█░█▀▄░█▀█░█▀▀░▀█▀░█▀▀░█▀▄\r\n█░░░█▀█░█▀█░█▀▄░█▀█░█░░░░█░░█▀▀░█▀▄\r\n▀▀▀░▀░▀░▀░▀░▀░▀░▀░▀░▀▀▀░░▀░░▀▀▀░▀░▀\r\n█▀▀░█▀▀░█▀█░█▀▀░█▀▄░█▀█░▀█▀░█▀█░█▀▄\r\n█░█░█▀▀░█░█░█▀▀░█▀▄░█▀█░░█░░█░█░█▀▄\r\n▀▀▀ ▀▀▀ ▀ ▀ ▀▀▀ ▀ ▀ ▀ ▀  ▀  ▀▀▀ ▀ ▀");
                Console.WriteLine("-------------------------------------");


                Console.WriteLine("\n\nVälj alternativ");
                Console.WriteLine("1. Generera karaktär");
                Console.WriteLine("2. Visa karaktärerer");
                Console.WriteLine("0. Avsluta program");

                string userInput = Console.ReadLine();


                switch (userInput)
                {
                    case ("1"):
                        Console.WriteLine("Genererar en karaktär");
                        break;

                    case ("2"):
                        Console.WriteLine("Visar karaktärer");
                        break;

                    case("0"):
                        isRunning = false;
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


    }
}
