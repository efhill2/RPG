using System;
using System.Collections.Generic;

namespace RPG
{
    class GameCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public GameCharacter (string theName, int theStrength, int theIntelligence)
        {
            Name = theName;
            Strength = theStrength;
            Intelligence = theIntelligence;
        }   
        
        public virtual void Play()
        {
            Console.Write($"{Name} (int {Intelligence}, str {Strength}). ");
        }
        
    }

    class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }

        public Warrior(string theName, int theStrength, int theIntelligence , string theWeaponType) : base(theName, theStrength, theIntelligence)
        {
            WeaponType = theWeaponType;
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Weapon is {WeaponType}.");
            Console.WriteLine(" ");
        }

    }

    class MagicUsingCharater : GameCharacter
    {
        public int MagicalEnergy { get; set; }

        public MagicUsingCharater(string theName, int theStrength, int theIntelligence, int theMagicalEnergy) : base(theName, theStrength, theIntelligence)
        {
            MagicalEnergy = theMagicalEnergy;
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Magical Energy is {MagicalEnergy}.");
        }
    }

    class Wizard : MagicUsingCharater
    {
        public int SpellNumber { get; set; }
        public Wizard(string theName, int theStrength, int theIntelligence, int theMagicalEnergy, int theSpellNumber) : base(theName, theStrength, theIntelligence, theMagicalEnergy)
        {
            SpellNumber = theSpellNumber;
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Times spells can be cast {SpellNumber}.");
            Console.WriteLine("");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> gameCharacters = new List<GameCharacter>();

            Warrior WarriorOne = new Warrior("Eugene the Brute", 10, 20, "Fist");
            Warrior WarriorTwo = new Warrior("Steven the Sniper", 15, 10, "Sniper Rifle");
            Warrior WarriorThree = new Warrior("Lawrence the Shooter", 12, 12, "Sawed Off Shotgun");
            Warrior WarriorFour = new Warrior("Geno the Mercenary", 15, 20, "Combat Knife");
            Warrior WarriorFive = new Warrior("Mercedes the Fighter", 10, 15, "Brass Knuckles");
            Wizard WizardOne = new Wizard("Jasmine the Dark Mage", 20, 5, 20, 30);            
            Wizard WizardTwo = new Wizard("Tisa the Healer", 12, 10, 30, 30);
            Wizard WizardThree = new Wizard("Genah the Clairvoyant", 20, 12, 20, 15);
            Wizard WizardFour = new Wizard("RaiGene the Light Mage", 20, 15, 30, 10);         
            Wizard WizardFive = new Wizard("Crystal the Water Mage", 20, 12, 25, 30);

            gameCharacters.Add(WarriorOne);
            gameCharacters.Add(WarriorTwo);
            gameCharacters.Add(WarriorThree);
            gameCharacters.Add(WarriorFour);
            gameCharacters.Add(WarriorFive);
            gameCharacters.Add(WizardOne);
            gameCharacters.Add(WizardTwo);
            gameCharacters.Add(WizardThree);
            gameCharacters.Add(WizardFour);
            gameCharacters.Add(WizardFive);

            Console.WriteLine("Welcome to my RPG");
            Console.WriteLine(" ");

            foreach (GameCharacter gameCharacter in gameCharacters)
            {
                gameCharacter.Play();
            }
        }
    }
}
