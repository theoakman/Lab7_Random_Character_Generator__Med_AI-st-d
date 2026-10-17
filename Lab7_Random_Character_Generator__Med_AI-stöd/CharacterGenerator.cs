using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_Random_Character_Generator__Med_AI_stöd
{
    internal class CharacterGenerator
    {
        private readonly Random random = new Random();


        // Posible character names and classes
        private string[] names = { "Eero Tonitucoor", "Nonsum Homo", "Kronk", "Euranya Atvash", "Lorezeion", "Amin Bidibamin", "Mina Badabina", "Abe", "Henry", "John Humanman", "Kevin" };
        private string[] classes = { "Warrior", "Mage", "Rogue", "Archer", "Paladin" };


    public Character GenerateCharacter()
        {
            string name = names[random.Next(names.Length)];
            string characterClass = classes[random.Next(classes.Length)];
            string[] possibleAbilities;

            int strength;
            int agility;
            int health;

            // The switch case makes sure that once a class has been generated the possible 
            // stats and abilities are limited to a set range and set of options

            // Generateted with AI after first case (Except for the ability names:))
            switch (characterClass)
            {
                case "Warrior":
                    strength = random.Next(15, 21);
                    agility = random.Next(5, 13);
                    health = random.Next(110, 151);

                    possibleAbilities = new string[] { "Berserk", "Polearm Mastery" };

                    break;

                case "Mage":
                    strength = random.Next(5, 11);
                    agility = random.Next(10, 16);
                    health = random.Next(60, 91);

                    possibleAbilities = new string[] { "Fireball", "Warp", "Shapeshift" };

                    break;

                case "Rogue":
                    strength = random.Next(8, 15);
                    agility = random.Next(15, 21);
                    health = random.Next(70, 101);
                    possibleAbilities = new string[] { "Stealth", "Lockpicking" };

                    break;

                case "Archer":
                    strength = random.Next(8, 15);
                    agility = random.Next(14, 21);
                    health = random.Next(80, 111);
                    possibleAbilities = new string[] { "Sniper", "Magic Arrows" };
                    break;

                case "Paladin":
                    strength = random.Next(12, 19);
                    agility = random.Next(5, 11);
                    health = random.Next(120, 151);
                    possibleAbilities = new string[] { "Healing", "Divine Smite" };
                    break;

                default:
                    throw new InvalidOperationException("Unknown character class.");
            }
            // assigns the ability from the previous possibleAbilities array
            string specialAbility = possibleAbilities[random.Next(possibleAbilities.Length)];

            // Constuctor for the new character onece everything has been generated
            Character newCharacter = new Character(
                name,
                characterClass, 
                strength,
                agility, 
                health,
                specialAbility
                );

            return newCharacter;
        }
    } 
}

