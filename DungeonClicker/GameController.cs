using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class Minion // Class for storing each type of minion's info
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double CoinsPerSec { get; set; }
        public double Cost {  get; set; }

        public Minion(string name, double coinsPerSec, double cost, int count=0)
        {
            this.Name = name;
            this.Count = count;
            this.Cost = cost;
            this.CoinsPerSec = coinsPerSec;
        }

    }

    // Simple container for upgrades
    public class Upgrade
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public bool Owned { get; set; }

        public Upgrade(string name, double cost, bool owned=false)
        {
            this.Name = name;
            this.Cost = cost;
            this.Owned = owned;
        }
    }


    internal class GameController
    {
        public double CurrentCoins;

        public double CoinsPerSecond; // Amount of coins produced every second
        public double CoinsPerClick; // Amount of coins produced per click

        private double ClickValue; // Base amount of coins gained from a single click
        private double ClickMultiplier; // Multiply the click value by this
        private double ClickValueBonus; // This gets added at the end-- increased via upgrades. Not affected by ClickMultiplier.
        private int LuckValue; // Probability of getting a lucky click is LuckValue / 10,000

        private int GameTimer; // Keeps track of how long the game has been played
        private Random Random;

        public Dictionary<string, Minion> Minions;

        public GameController()
        {
            // Defining each minion type and its base stats
            Minions = new Dictionary<string, Minion>
            {
                ["Goblin"] = new Minion("Goblin", 0.1, 10),
                ["Skeleton"] = new Minion("Skeleton", 1, 100),
                ["Gargoyle"] = new Minion("Gargoyle", 5, 1000),
                ["Wizard"] = new Minion("Wizard", 20, 2000),
                ["Ogre"] = new Minion("Ogre", 50, 5000),
                ["Elemental"] = new Minion("Elemental", 150, 20000),
                ["Dragon"] = new Minion("Dragon", 500, 100000),
                ["Necromancer"] = new Minion("Necromancer", 3500, 1000000)
            };

            // Defining each upgrade
            Upgrades = new Dictionary<string, Upgrade>
            {
                ["BronzeMouseUpgrade"] = new Upgrade("BronzeMouseUpgrade", 300),
                ["SilverMouseUpgrade"] = new Upgrade("SilverMouseUpgrade", 2000),
                ["GoldenMouseUpgrade"] = new Upgrade("GoldenMouseUpgrade", 10000),
                ["MagicMouseUpgrade"] = new Upgrade("MagicMouseUpgrade", 25000),

                ["GoblinUpgrade"] = new Upgrade("GoblinUpgrade", 300),
                ["SkeletonUpgrade"] = new Upgrade("SkeletonUpgrade", 750),
                ["GargoyleUpgrade"] = new Upgrade("GargoyleUpgrade", 2500),
                ["WizardUpgrade"] = new Upgrade("WizardUpgrade", 7500),
                ["OgreUpgrade"] = new Upgrade("OgreUpgrade", 15000),
                ["ElementalUpgrade"] = new Upgrade("ElementalUpgrade", 50000),
                ["DragonUpgrade"] = new Upgrade("DragonUpgrade", 300000),
                ["NecromancerUpgrade"] = new Upgrade("NecromancerUpgrade", 1500000)
            };

            CurrentCoins = 0;
            CoinsPerClick = 1;
            ClickValue = 1;
            ClickMultiplier = 1;
            ClickValueBonus = 0;
            LuckValue = 0;

            CoinsPerSecond = 0;
            
            GameTimer = 0;
            Random = new Random();
        }

        // Runs every time the player clicks the coin
        public void Click()
        {
            CurrentCoins += CoinsPerClick;
            if (Random.Next(1, 10000) <= LuckValue)
            {
                LuckyClick();
            }
        }

        private void LuckyClick()
        {
            CurrentCoins *= 2;
        }

        public void UpdateCoinsPerClick()
        {
            CoinsPerClick = (ClickValue * ClickMultiplier) + ClickValueBonus;
        }

        // Returns true if purchase was successful
        public bool Purchase(string minionType, bool free=false)
        {
            if (minionType == "") { return false; }
            
            Minion minion = Minions[minionType];

            if (free)
            {
                minion.Count++;
                UpdateMinionCost(minionType);
                CalculateUpgrades();
                return true;
            }

            if (minion.Cost <= CurrentCoins)
            {
                minion.Count++;
                CurrentCoins -= minion.Cost;
                UpdateMinionCost(minionType);
                CalculateUpgrades();
                return true;
            }

            return false;
        }

        // Cost of a minion increases as you buy more of them
        private void UpdateMinionCost(string minionType)
        {
            Minion minion = Minions[minionType];
            minion.Cost += (minion.Cost * 0.12);
        }

        private void UpdateCoinsPerSecond()
        {
            CoinsPerSecond = 0;
            foreach(var minion in Minions.Values)
            {
                CoinsPerSecond += (minion.CoinsPerSec * minion.Count);
            }
        }

        // This runs every second
        public void GameTick()
        {
            CurrentCoins += CoinsPerSecond;
            GameTimer++;
        }

        public double GetMinionCost(string minion)
        {
            return Math.Round(Minions[minion].Cost, 1);
        }

        public double GetMinionCoinsPerSec(string minion)
        {
            return Math.Round(Minions[minion].CoinsPerSec, 1);
        }

        public string GetMinionDescription(string minion)
        {
            switch (minion)
            {
                case "Goblin":
                    return "These expendable green goblins will slowly mine away at gold ore.";
                case "Skeleton":
                    return "Skeletons are surprisingly effective at mining gold; their sharp bones make for great pickaxes. They have no muscles, so don't worry about overworking them.";
                case "Gargoyle":
                    return "Gargoyles are great defenders for your dungeon. They look like stone statues at first glance, but will steal gold from any unsuspecting passersby unfortunate enough not to notice.";
                case "Wizard":
                    return "Wizards can cast powerful spells to aid you in your quest for coin. Purple robe and magic wand not included.";
                case "Ogre":
                    return "Ogres can pillage small villages for you and bring you back their loot.";
                case "Elemental":
                    return "Elementals are champions of the earth. For a price, they can turn ordinary rocks into solid gold.";
                case "Dragon":
                    return "Dragons are greedy creatures with a strong affinity for treasure. They can use a variety of means to acquire it.";
                case "Necromancer":
                    return "Necromancers can raise entire armies from the souls of the dead. Your overworked minions will no longer get the luxury of resting in peace.";
                default:
                    return "Description not found.";
            }

        }

        // UPGRADES
        public Dictionary<string, Upgrade> Upgrades;

        private void CalculateUpgrades()
        {
            // Reset the click stats before calculating the new ones
            ClickValue = 1;
            ClickMultiplier = 1;
            ClickValueBonus = 0;
            LuckValue = 0;

            // GOBLIN: 2x coins
            if (Upgrades["GoblinUpgrade"].Owned)
            {
                Minions["Goblin"].CoinsPerSec = 0.2;
            }

            // SKELETON: 2.5x coins
            if (Upgrades["SkeletonUpgrade"].Owned)
            {
                Minions["Skeleton"].CoinsPerSec = 2.5;

            }

            // GARGOYLE: +0.5 coins for every gargoyle
            if (Upgrades["GargoyleUpgrade"].Owned)
            {
                Minions["Gargoyle"].CoinsPerSec = 5 + (0.5 * Minions["Gargoyle"].Count);
            }

            // WIZARD: +0.3 coins per skeleton
            if (Upgrades["WizardUpgrade"].Owned)
            {
                Minions["Wizard"].CoinsPerSec = 20 + (0.3 * Minions["Skeleton"].Count);
            }

            // OGRE: Each ogre gains 1% more coins for every goblin owned
            if (Upgrades["OgreUpgrade"].Owned)
            {
                Minions["Ogre"].CoinsPerSec = 50 + (50 * (Minions["Goblin"].Count / 100.0));
            }

            // ELEMENTAL: Each elemental provides +30 coins per click and +0.01% lucky click chance
            if (Upgrades["ElementalUpgrade"].Owned)
            {
                ClickValue += 30 * Minions["Elemental"].Count;
                LuckValue += 1 * Minions["Elemental"].Count;
            }

            // DRAGON: Gains 0.01% of your current coins as coins per second. The logic is handled via DragonUpgradeUpdate()

            // NECROMANCER: Gain one free skeleton every 20 seconds. The logic for it is handled inside the form class

            // ---------------------MOUSE UPGRADES----------------------------

            // BRONZE: Gain 10 coins on every click
            if (Upgrades["BronzeMouseUpgrade"].Owned)
            {
                ClickValue += 9;
            }

            // SILVER: Gain 2x coins on every click
            if (Upgrades["SilverMouseUpgrade"].Owned)
            {
                ClickMultiplier = 2;
            }

            // GOLD: Gain 5% of your coins per second on every click
            if (Upgrades["GoldenMouseUpgrade"].Owned)
            {
                ClickValueBonus += 0.05 * CoinsPerSecond;
            }

            // MAGIC: 0.05% chance of doubling your current coins with every click.
            if (Upgrades["MagicMouseUpgrade"].Owned)
            {
                LuckValue += 5;
            }


            UpdateCoinsPerClick();
            UpdateCoinsPerSecond();

        }

        public string GetUpgradeDescription(string upgrade)
        {
            switch (upgrade)
            {
                case "BronzeMouseUpgrade":
                    return "Enter the bronze age with this bronze mouse upgrade.\n\nEffects: Gain 10 coins per click.\nCost: 300";
                case "SilverMouseUpgrade":
                    return "Ignore the fact that bronze is more durable than silver-- when clicking a large floating coin, logic need not be of concern.\n\nEffects: Gain twice as many coins per click.\nCost: 2,000";
                case "GoldenMouseUpgrade":
                    return "The alchemists have concocted a solution capable of turning even digital mouse cursors into solid gold.\n\nEffects: Gain 5% of your current coins per second on every click.\nCost: 10,000 ";
                case "MagicMouseUpgrade":
                    return "Experience the magic of gambling and dumb luck with this magic mouse upgrade.\n\nEffects: Each click has a 0.1% chance of being lucky, doubling your current coins.\nCost: 25,000";
                case "GoblinUpgrade":
                    return "These industrial-grade mythril pickaxes will improve your goblins' efficiency twofold.\n\nEffects: Goblins produce 2x coins per second.\nCost: 300";
                case "SkeletonUpgrade":
                    return "No need to buy strength potions for your skeleton minions-- calcium is king when it comes to strengthening bones.\n\nEffects: Skeletons produce 2.5x coins per second.\nCost: 750";
                case "GargoyleUpgrade":
                    return "Gargoyles are nearly as effective at flying in groups as they are at looking like cheap Halloween props.\n\nEffects: Gargoyles gain +0.5 coins per second for each other gargoyle\nCost: 2,500";
                case "WizardUpgrade":
                    return "Teach your wizards the secrets of dark magic by enlisting them in this questionably-ethical apprenticeship.\n\nEffects: Wizards gain +0.3 coins per skeleton\nCost: 7,500";
                case "OgreUpgrade":
                    return "Ogres are no smarter than goblins are, but that doesn't stop them from being effective leaders.\n\nEffects: Ogres gain +1% coins per second for every goblin\nCost: 15,000";
                case "ElementalUpgrade":
                    return "Elementals can channel their earthly powers into your mouse, which is conveniently made from rare earth metals.\n\nEffects: Each elemental grants +30 coins per click and +0.01% lucky click chance\nCost: 50,000";
                case "DragonUpgrade":
                    return "Keep your gold extra-secure with this dragon upgrade. They'll now protect you from looters, thieves, and predatory interest rates.\n\nEffects: Dragons gain +0.01% of your current coins as coins per second\nCost: 300,000";
                case "NecromancerUpgrade":
                    return "You're not quite sure what the necromancers were doing to earn you money before this upgrade, but extra workers is always appreciated.\n\nEffects: Each necromancer summons one free skeleton every 20 seconds\nCost: 1,500,000";
                default:
                    return "";
            }

        }

        // Returns true if the purchase was successful
        public bool PurchaseUpgrade(string upgradeName)
        {
            if (upgradeName == "") { return false; }
            
            Upgrade upgrade = Upgrades[upgradeName];

            if (upgrade.Owned == true)
            {
                return false;
            }

            if (CurrentCoins < upgrade.Cost)
            {
                return false;
            }

            CurrentCoins -= upgrade.Cost;
            upgrade.Owned = true;
            CalculateUpgrades();
            return true;
        }

        public void DragonUpgradeUpdate()
        {
            Minions["Dragon"].CoinsPerSec = 500 + (CurrentCoins *0.0001);
            UpdateCoinsPerSecond();
            CalculateUpgrades();
        }

    }
}
