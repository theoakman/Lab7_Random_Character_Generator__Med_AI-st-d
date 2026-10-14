using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_Random_Character_Generator__Med_AI_stöd
{
    internal class CharacterGenerator
    {
        private readonly Random random = new Random();


        // Posible character names, classes, and abilities
        private string[] names = {"Eero Tonitucoor", "Nonsum Homo", "Kronk", "Euranya Atvash", "Lorezeion", "Amin Bidibamin", "Mina Badabina" };
        private string[] classes = {"Warrior", "Mage", "Rouge", "Archer", "Paladin" };
        private string[] abilities = { "Berserk", "Fireball", "Stealth", "Divine Smite", "Shapeshift", "Warp", "Healing" };


    }
}
