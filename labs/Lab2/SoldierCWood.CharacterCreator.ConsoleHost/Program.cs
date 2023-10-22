
// ITSE 1430 Fall 2023
// Lab 2 Character Creator
// Written by Chris "Soldier" Wood
// 09 30 23

using SoldierCWood.CharacterCreator;

partial class Program
{
    static void Main ( string[] args )
    {

       DisplayIntro();

       var done = false;
       bool characterExists = false;
      
       Character myCharacter = new Character();
        
        do
        {
            switch (GetUserSelection())
            {
                case 1:
                    if(characterExists == false) {
                    AddCharacter(myCharacter);
                    characterExists = true;
                } else
                {
                    Console.WriteLine("Character Already exists");
                }

                break;
                case 2:
                    ViewCharacter(myCharacter);
                break;
                case 3:
                {
                    if (String.IsNullOrEmpty(myCharacter.Name))
                    {
                        Console.WriteLine("You have not yet created a character.");
                        AddCharacter(myCharacter);
                    } else
                        EditCharacter(myCharacter);
                }
                break;
                case 4:
                    characterExists = DeleteCharacter(myCharacter, characterExists);
                break;
                case 0:
                    if (!Confirmation("Are you sure you want to quit the game (Y/N/)?"))
                    {
                        done = true;
                    }
                    break;
                case 5: Console.WriteLine("\n"); break;
            };
        } while (!done);
               
    }

    private static void DisplayIntro ()
    {

        Console.WriteLine("ITSE 1430 Character Creator");
        Console.WriteLine("Written by Chris \"Soldier\" Wood");
        Console.WriteLine("Fall 2023\n");

    }

    private static int GetUserSelection ()
    {
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("-----------------------");
        Console.WriteLine("A) Add character");
        Console.WriteLine("V) View character");
        Console.WriteLine("E) Edit character");
        Console.WriteLine("D) Delete Character");
        Console.WriteLine("Q) Quit\n");

        do
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.A: return 1;
                case ConsoleKey.V: return 2;
                case ConsoleKey.E: return 3;
                case ConsoleKey.D: return 4;
                case ConsoleKey.Q: return 0;

                default: Console.WriteLine("Unknown option"); return 5;
            };
        } while (true);
    }

    private static bool Confirmation ( string message )
    {
        return ReadBoolean(message);
    }

    private static bool ReadBoolean ( string message )
    {
        Console.WriteLine(message);

        while (true)
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Y: return false;
                case ConsoleKey.N: return true;
            };
        }
    }

    private static void AddCharacter (Character myCharacter)
    {
        //Character.AddCharacterName(myCharacter);
        AddCharacterName(myCharacter);
        AddCharacterProfession(myCharacter);
        AddCharacterRace(myCharacter);
        AddCharacterBio(myCharacter);
        AssignStrength(myCharacter);
        AssignIntelligence(myCharacter);
        AssignAgility(myCharacter);
        AssignConstitution(myCharacter);
        AssignCharisma(myCharacter);
        ConfirmCreation(myCharacter);
    }

    /// <summary> Adds character name to character. </summary>
    private static void AddCharacterName ( Character newChar )
    {
        Console.WriteLine("Enter character name: ");
        string value = Console.ReadLine();
        while (String.IsNullOrEmpty(value))
        {
            Console.WriteLine("Must input at least one character");
            Console.WriteLine("Enter character name: ");
            value = Console.ReadLine();
        }
        newChar.Name = value;

    }

    /// <summary> Adds profession to character. </summary>
    public static void AddCharacterProfession ( Character newChar )
    {
        Console.WriteLine();

        DisplayProfessionChoices();

        var finish = false;

        do
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.F:
                newChar.Profession = "Fighter";
                finish = true;
                break;
                case ConsoleKey.H:
                newChar.Profession = "Hunter";
                finish = true;
                break;
                case ConsoleKey.P:
                newChar.Profession = "Priest";
                finish = true;
                break;
                case ConsoleKey.R:
                newChar.Profession = "Rogue";
                finish = true;
                break;
                case ConsoleKey.W:
                newChar.Profession = "Wizard";
                finish = true;
                break;
                default:
                Console.WriteLine("Unknown option");
                DisplayProfessionChoices();
                break;
            };
        } while (!finish);

    }

    /// <summary> Displays choices for profession. </summary>
    public static void DisplayProfessionChoices ()
    {
        Console.WriteLine("Enter character profession");
        Console.WriteLine("Available choices: ");
        Console.WriteLine("F) Fighter");
        Console.WriteLine("H) Hunter");
        Console.WriteLine("P) Priest");
        Console.WriteLine("R) Rogue");
        Console.WriteLine("W) Wizard");
    }

    /// <summary> Edit the profession of the current character. </summary>
    public static void EditProfession ( Character newChar )
    {
        Console.WriteLine($"Your current profession is: {newChar.Profession}");
        Console.WriteLine("Do you wish to change your profession? Please enter Y or N: ");

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.Y:
            {
                AddCharacterProfession(newChar);
                Console.WriteLine("Your new profession is: " + newChar.Profession);
                Console.WriteLine();
            }
            break;
            case ConsoleKey.N:
            {
                Console.WriteLine("Your profession remains as: " + newChar.Profession);
                Console.WriteLine();
            }
            break;
            default:
            break;
        };
    }

    /// <summary> Edit the characteristics of the current character. </summary>
    public static void EditCharacter ( Character newChar )
    {
        EditName(newChar);
        EditProfession(newChar);
        EditRace(newChar);
        EditBio(newChar);

        Console.WriteLine("Sorry, you cannot edit your strength, intelligence, agility, constitution, or charisma.");
        Console.WriteLine("You were born with these regardless of other character traits.");
        Console.WriteLine();
    }

    /// <summary> Edit character name. </summary>
    public static void EditName ( Character newChar )
    {
        Console.WriteLine($"Your current name is: {newChar.Name}");
        Console.WriteLine("Do you wish to change your name? Please enter Y or N: ");

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.Y:
            {
                Console.WriteLine("Enter new name: ");
                newChar.Name = Console.ReadLine();
                Console.WriteLine("Your new name is: " + newChar.Name);
                Console.WriteLine();
            }
            break;
            case ConsoleKey.N:
            {
                Console.WriteLine("Your name remains as: " + newChar.Name);
                Console.WriteLine();
            }
            break;
            default:
            break;
        };
    }
    /// <summary> Select new character's race if user opts to. </summary>
    public static void EditRace ( Character newChar )
    {
        Console.WriteLine($"Your current race is: {newChar.Race}");
        Console.WriteLine("Do you wish to change your race? Please enter Y or N: ");

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.Y:
            {
                AddCharacterRace(newChar);
                Console.WriteLine("Your new race is: " + newChar.Race);
                Console.WriteLine();
            }
            break;
            case ConsoleKey.N:
            {
                Console.WriteLine("Your race remains as: " + newChar.Race);
                Console.WriteLine();
            }
            break;
            default:
            break;
        };
    }

    /// <summary> Option to edit character biography. </summary>
    public static void EditBio ( Character newChar )
    {
        Console.WriteLine($"Your current bio states: {newChar.Bio}");
        Console.WriteLine("Do you wish to modify your bio? Please enter Y or N: ");

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.Y:
            {
                AddCharacterBio(newChar);
                Console.WriteLine("Your new bio states: " + newChar.Bio);
                Console.WriteLine();
            }
            break;
            case ConsoleKey.N:
            {
                Console.WriteLine("Your bio still says: " + newChar.Bio);
                Console.WriteLine();
            }
            break;
            default:
            break;
        };
    }

    /// <summary> Adds race choice to character. </summary>
    public static void AddCharacterRace ( Character newChar )
    {
        Console.WriteLine();

        DisplayRaceChoices();

        var complete = false;

        do
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D:
                newChar.Race = "Dwarf";
                complete = true;
                break;
                case ConsoleKey.E:
                newChar.Race = "Elf";
                complete = true;
                break;
                case ConsoleKey.G:
                newChar.Race = "Gnome";
                complete = true;
                break;
                case ConsoleKey.H:
                newChar.Race = "Half Elf";
                complete = true;
                break;
                case ConsoleKey.U:
                newChar.Race = "Human";
                complete = true;
                break;
                default:
                Console.WriteLine("Unknown option");
                DisplayRaceChoices();
                break;
            };
        } while (!complete);

        Console.WriteLine();
    }

    /// <summary> Displays choices for race. </summary>
    public static void DisplayRaceChoices ()
    {
        Console.WriteLine("Enter character race");
        Console.WriteLine("Available choices: ");
        Console.WriteLine("D) Dwarf");
        Console.WriteLine("E) Elf");
        Console.WriteLine("G) Gnome");
        Console.WriteLine("H) Half Elf");
        Console.WriteLine("U) Human");
    }

    /// <summary> Customer defined character biography, which is optional. </summary>
    public static void AddCharacterBio ( Character newChar )
    {
        Console.WriteLine("Enter brief character biography, which is optional: ");
        string value = Console.ReadLine();

        newChar.Bio = value;

        Console.WriteLine();
    }

    /// <summary> Confirm whether or not character has been created. </summary>
    public static void ConfirmCreation ( Character newChar )
    {
        if (String.IsNullOrEmpty(newChar.Name))
        {
            Console.WriteLine("Character has not yet been created. Please make appropriate selection to create a character.");
            Console.WriteLine();
            return;
        } else
        {
            Console.WriteLine("Character has successfully been created.\n");
        }
    }

    /// <summary> Determine physical power. </summary>
    public static void AssignStrength ( Character newChar )
    {
        newChar.Strength = GeneratePercentage();

        Console.WriteLine("Your character's strength level: " + newChar.Strength);

    }

    /// <summary>
    /// Randomly generate integer to use for character attribute values.  </summary>
    /// <returns>Randomly generate number between 1 and 100.</returns>
    public static int GeneratePercentage ()
    {
        return Random.Shared.Next(1, 101);
    }

    /// <summary> Assigns character intelligence level. </summary>
    public static void AssignIntelligence ( Character newChar )
    {
        newChar.Intelligence = GeneratePercentage();

        Console.WriteLine("Your character's level of intelligence: " + newChar.Intelligence);

    }

    /// <summary> Assigns amount of agility character possesses. </summary>
    public static void AssignAgility ( Character newChar )
    {
        newChar.Agility = GeneratePercentage();

        Console.WriteLine("Your character's agility: " + newChar.Agility);

    }

    /// <summary> Determines character's constitution. </summary>
    public static void AssignConstitution ( Character newChar )
    {
        newChar.Constitution = GeneratePercentage();

        Console.WriteLine("Your character's constitution: " + newChar.Constitution);

    }

    /// <summary> Assign level of charisma to character. </summary>
    public static void AssignCharisma ( Character newChar )
    {
        newChar.Charisma = GeneratePercentage();

        Console.WriteLine("Your character's charisma: " + newChar.Charisma);

        Console.WriteLine();

    }

    /// <summary> Check for character's existence, then call method to display current character attributes. </summary>
    public static void ViewCharacter ( Character newChar )
    {
        if (String.IsNullOrEmpty(newChar.Name))
        {
            Console.WriteLine("Character has not yet been created. Please make appropriate selection to create a character.");
            Console.WriteLine();
            return;
        } else
        {
            DisplayCharacter(newChar);
        }
    }
    /// <summary> Display current character attributes. </summary>
    public static void DisplayCharacter ( Character newChar )
    {
        Console.WriteLine("Character name:" + "\t\t" + newChar.Name);
        Console.WriteLine("Character profession:" + "\t" + newChar.Profession);
        Console.WriteLine("Character race:" + "\t\t" + newChar.Race);
        Console.WriteLine("Character biography: " + "\t" + newChar.Bio);
        Console.WriteLine();
        Console.WriteLine("Character strength: " + "\t\t" + newChar.Strength);
        Console.WriteLine("Character intelligence: " + "\t" + newChar.Intelligence);
        Console.WriteLine("Character agility: " + "\t\t" + newChar.Agility);
        Console.WriteLine("Character constitution: " + "\t" + newChar.Constitution);
        Console.WriteLine("Character charisma: " + "\t\t" + newChar.Charisma);
        Console.WriteLine();

    }

    public static bool DeleteCharacter ( Character newChar, bool exists )
    {
        if (String.IsNullOrEmpty(newChar.Name))
        {
            Console.WriteLine("Character has not yet been created. Please make appropriate selection to create a character.");
            Console.WriteLine();
            return exists;
        } else
        {
            Console.WriteLine("Are you sure you want to delete your character? Please enter Y or N: ");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Y:
                DeleteSteps(newChar);
                exists = false;
                return exists;

                case ConsoleKey.N:
                {
                    Console.WriteLine("Your character lives on.");
                    Console.WriteLine();
                    return exists;
                }
                default:
                return exists;
            };
        }
    }
    /// <summary> Steps to delete current character. </summary>
    public static void DeleteSteps ( Character newChar )
    {
        newChar.Name = null;
        newChar.Race = null;
        newChar.Profession = null;
        newChar.Bio = null;
        newChar.Strength = 0;
        newChar.Intelligence = 0;
        newChar.Agility = 0;
        newChar.Constitution = 0;
        newChar.Charisma = 0;


        Console.WriteLine("Your character has been deleted.");
        Console.WriteLine();

    }


}