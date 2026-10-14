namespace Lab7_Random_Character_Generator__Med_AI_stöd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CharacterGenerator generator = new CharacterGenerator();

            Character myCharacter = generator.GenerateCharacter();

            Console.WriteLine($"Name: {myCharacter.Name}");
            Console.WriteLine($"Class: {myCharacter.CharacterClass}");
            Console.WriteLine($"Strength: {myCharacter.Strength}");
            Console.WriteLine($"Agilty: {myCharacter.Agility}");
            Console.WriteLine($"Ability: {myCharacter.SpecialAbility}");

        }


    }
}
