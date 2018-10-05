using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textbasedgame
{
    public class Program
    {
        public class Character
        {
            public string Name;
            public int Health; // delcaring variables
            public int Damage; 
            public int Mitigation;
            public Character(string givenName, int givenHealth, int givenDamage, int givenMitigation)
            {
                this.Name = givenName;
                this.Health = givenHealth;
                this.Damage = givenDamage;
                this.Mitigation = givenMitigation;

            }


        }

        public class Monster
        {
            public string Name;
            public int Health;
            public int Damage;
            public int Mitigation;
            public Monster(string givenName, int givenHealth, int givenDamage, int givenMitigation)
            {
                this.Name = givenName;
                this.Health = givenHealth;
                this.Damage = givenDamage;
                this.Mitigation = givenMitigation;
            }

            public static void Main()
            {
                Character userCharacter = new Character("placeholder", 0, 0, 0);
                Monster newMonster = new Monster("placeholder", 0, 0, 0);


                Console.WriteLine("What is your name?");
                string userName = Console.ReadLine();
                Console.WriteLine("So your name is " + userName + ", sounds gay");
                // declaring struct name
                Console.WriteLine("Please choose Wizard or Paladan");
                string usercharchoice = Console.ReadLine();
                bool wizard = usercharchoice == "wizard";
                bool paladin = usercharchoice == "paladin";
                while (wizard == false && paladin == false)
                {
                    Console.WriteLine("Invalid Selection");
                    usercharchoice = Console.ReadLine();
                    paladin = usercharchoice == "paladin";
                    wizard = usercharchoice == "wizard";
                }

                if (paladin == true)
                {
                    userCharacter = new Character("Paladin", 120, 8, 4);
                }
                else if (wizard == true)
                {
                    userCharacter = new Character("Wizard", 75, 15, 2);
                }


                Console.WriteLine("type in character to access stats screen or continue to play the game.");
                string command = Console.ReadLine(); ////changes
                bool commandInput = true;
                if (command == "continue")
                    {
                       commandInput = false;
                    }
                while (command != "character" && commandInput == true)
                    {
                        Console.WriteLine("Invalid Selection Please retry!");
                        command = Console.ReadLine();
                        commandInput = true;

                    }                                           

                while (commandInput == true)
                {
                    Console.WriteLine("Please enter command:");
                    Console.WriteLine("stats - your stats will be displayed.");
                    Console.WriteLine("hp - your health will be displayed.");
                    Console.WriteLine("dmg - your damage stat will be displayed.");
                    Console.WriteLine("def - your mitigation stat will be displayed.");
                    Console.WriteLine("continue - you will continue to the game.");
                    command = Console.ReadLine(); //// to here
                    commandInput = true;
                    
                        if (command == "stats")
                    {
                        Console.WriteLine(userCharacter.Health);
                        Console.WriteLine(userCharacter.Damage);
                        Console.WriteLine(userCharacter.Mitigation);
                    }
                    else if (command == "hp")
                    {
                        Console.WriteLine(userCharacter.Health);
                    }
                    else if (command == "dmg")
                    {
                        Console.WriteLine(userCharacter.Damage);
                    }
                    else if (command == "def")
                    {
                        Console.WriteLine(userCharacter.Mitigation);
                    }
                    else if (command == "continue")
                    {
                        Random rnd = new Random();
                        int encounterType = rnd.Next(1, 2);
                        int monsterType = rnd.Next();
                        int eventDice = rnd.Next();
                        if (encounterType == 1)
                        {
                            monsterType = rnd.Next(1, 5);
                            if (monsterType == 1)
                            {
                                newMonster = new Monster("Ghoul", 60, 5, 3);
                            }
                            else if (monsterType == 2)
                            {
                                newMonster = new Monster("Ghost", 30, 9, 1);
                            }
                            else if (monsterType == 3)
                            {
                                newMonster = new Monster("Skeleton", 25, 11, 2);
                            }
                            else if (monsterType == 4)
                            {
                                newMonster = new Monster("Troll", 80, 3, 5);
                            }
                            else if (monsterType == 5)
                            {
                                newMonster = new Monster("gay retard", 10000, 69, 1337);
                            }

                            Console.WriteLine("Oh no there is a spooky monster! It's a " + newMonster.Name);
                            Console.WriteLine("What will you do?");
                            Console.WriteLine("Run Fight Sneak Playdead Examine");
                            string roomCommand = Console.ReadLine();
                            bool roomCommandInput = true;
                            
                            if (roomCommand != "run" && roomCommand != "fight" && roomCommand != "sneak" && roomCommand != "playdead" && roomCommand != "examine")
                                {
                                    roomCommandInput = false;
                                }                           
                                                            
                            while (roomCommandInput == false)
                                {
                                    Console.WriteLine("That's not a valid option!");    
                                    roomCommand = Console.ReadLine();
                                    roomCommandInput = true;
                                }
                            while (roomCommandInput == true)
                            {

                            if (roomCommand == "examine")
                            {
                                Console.WriteLine(newMonster.Name);
                                Console.WriteLine(newMonster.Health);
                                Console.WriteLine(newMonster.Damage);
                                Console.WriteLine(newMonster.Mitigation);
                                roomCommand = Console.ReadLine();
                                roomCommandInput = true;
                            } 
                            }
                        }

                        if (encounterType == 2)
                        {
                            Console.WriteLine("This room is seems awfully suspicious");
                            Console.WriteLine("What will you do?");
                        }

                        if (encounterType == 3)
                        {
                            Console.WriteLine("Treasure room how wonderful!");
                            Console.WriteLine("What will you do?");
                        }

                        if (encounterType == 4)
                        {
                            Console.WriteLine("This looks likea good place to rest.");
                            Console.WriteLine("What will you do?");
                        }
                    }
                }                  
            }   
        }
    }
}
