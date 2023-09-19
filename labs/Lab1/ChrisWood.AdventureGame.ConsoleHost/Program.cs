// Lab 1 Adventure Game
// Written by Chris Wood
// Fall 2023


// Entry point
int currentRoom = 1;

DisplayIntro();

var done = false;

do
{
    switch (GetUserSelection())
    {
        case 1:
            currentRoom = MoveNorth(currentRoom);
            break;
        case 2: 
            currentRoom = MoveSouth(currentRoom);
            break;
        case 3:
            currentRoom = MoveEast(currentRoom);
            break;
        case 4:
            currentRoom = MoveWest(currentRoom);
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


bool Confirmation ( string message )
{
    return ReadBoolean(message);
}

bool ReadBoolean ( string message )
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


void DisplayIntro ()
{

    Console.WriteLine("ITSE 1430 Adventure Game");
    Console.WriteLine("Written by Chris Wood");
    Console.WriteLine("Fall 2023\n");

    Console.WriteLine("You are hanging out with friends for a night of drinking, dining, and fun.");
    Console.WriteLine("In the early morning hours, you all climb into one car with a designated driver and head home.");
    Console.WriteLine("While driving on the highway, the driver notices the fuel indicator says there is 0 miles left.");
    Console.WriteLine("The driver says he has no choice but to stop right away for gas. You notice that you are in");
    Console.WriteLine("a run-down section of town. The gas station you stop at is in desperate need of repair");
    Console.WriteLine("You need to use the restroom and it can't wait. You go inside and have to wait to use");
    Console.WriteLine("the bathroom. You finally get to use it. You hurry, rush back outside, and cannot believe it...");
    Console.WriteLine("Your friends have left you. They must not have realized you did not make it back to the car.");
    Console.WriteLine("You reach into your pocket for your phone and freeze in horror. You forgot it had been charging");
    Console.WriteLine("in the car, and you had not taken it with you. You go back into the store and ask the clerk to");
    Console.WriteLine("call the police on your behalf for help. The clerk refuses because they sell illegal items in the");
    Console.WriteLine("store and cannot risk having the police there. An old man approaches you and offers to give");
    Console.WriteLine("you a ride to the police station if you will help him run a few errands along the way.");
    Console.WriteLine("He appears very kind, old, and feeble, so you feel safe and take him up on his offer.");
    Console.WriteLine("Will your street smarts allow you to successfully navigate through the hood without");
    Console.WriteLine("endangering yourself unnecessarily, or has life not properly prepared you for how to stay");
    Console.WriteLine("safe in the hood?\n");
}

int GetUserSelection ()
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("-----------------------");
    Console.WriteLine("N) Move North");
    Console.WriteLine("S) Move South");
    Console.WriteLine("E) Move East");
    Console.WriteLine("W) Move West");
    Console.WriteLine("Q) Quit\n");

    do
    {
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.N: return 1;
            case ConsoleKey.S: return 2;
            case ConsoleKey.E: return 3;
            case ConsoleKey.W: return 4;
            case ConsoleKey.Q: return 0;

            default: Console.WriteLine("Unknown option"); return 5;
        };
    } while (true);
}

int MoveNorth ( int currentRoom )
{
    if ((currentRoom == 1) || (currentRoom==2) || (currentRoom==3))
    {
        Console.WriteLine("You cannot move North from this area. Please try a different direction.\n");
    } else if (currentRoom == 4)
    {
        currentRoom = 1;
        room1Scenario();
    } else if (currentRoom ==5)
    {
        currentRoom = 2;
        room2Scenario();
    } else if (currentRoom == 6)
    {
        currentRoom = 3;
        room3Scenario();
    } else if (currentRoom == 7)
    {
        currentRoom = 4;
        room4Scenario();
    } else if (currentRoom == 8)
    {
        currentRoom = 5;
        room5Scenario();
    } else if (currentRoom == 9)
    {
        currentRoom = 6;
        room6Scenario();
    }

    return currentRoom;
}

int MoveSouth ( int currentRoom )
{
    if (currentRoom == 1)
    {
        currentRoom = 4;
        room4Scenario();
    } else if (currentRoom == 2)
    {
        currentRoom = 5;
        room5Scenario();
    } else if (currentRoom == 3)
    {
        currentRoom = 6;
        room6Scenario();
    } else if (currentRoom == 4)
    {
        currentRoom = 7;
        room7Scenario();
    } else if (currentRoom == 5)
    {
        currentRoom = 8;
        room8Scenario();
    } else if (currentRoom == 6)
    {
        currentRoom = 9;
        room9Scenario();
    } else if ((currentRoom==7) || (currentRoom==8) || (currentRoom==9))
    {
        Console.WriteLine("You cannot move South from this area. Please try a different direction.\n");
    }
    return currentRoom;
}

int MoveEast (int currentRoom)
{
    if (currentRoom == 1)
    {
        currentRoom = 2;
        room2Scenario();
     }
    else if (currentRoom == 2)
    {
        currentRoom = 3;
        room3Scenario();
    }
    else if (currentRoom == 4)
    {
        currentRoom = 5;
        room5Scenario();
    }
    else if (currentRoom == 5)
    {
        currentRoom = 6;
        room6Scenario();
    }
    else if (currentRoom == 7)
    {
        currentRoom = 8;
        room8Scenario();
    } else if (currentRoom == 8)
    {
        currentRoom = 9;
        room9Scenario();
    }
    else if ((currentRoom==3) || (currentRoom==6) || (currentRoom==9))
    {
        Console.WriteLine("You cannot move East from this area. Please try a different direction.\n");
    }

    return currentRoom;
}

int MoveWest (int currentRoom)
{
    if (currentRoom == 2)
    {
        currentRoom = 1;
        room1Scenario();
    } 
    else if (currentRoom == 5)
    {
        currentRoom = 4;
        room4Scenario();
    } 
    else if (currentRoom == 8)
    {
        currentRoom = 7;
        room7Scenario();
    } 
    else if (currentRoom == 3)
    {
        currentRoom = 2;
        room2Scenario();
    } 
    else if (currentRoom == 6)
    {
        currentRoom = 5;
        room5Scenario();
    } 
    else if (currentRoom == 9)
    {
        currentRoom = 8;
        room8Scenario();
    }
    else if ((currentRoom == 1) || (currentRoom == 4) || (currentRoom == 7))
    {
        Console.WriteLine("You cannot move West from this area. Please try a different direction.\n");
    }

    return currentRoom;
}

void room1Scenario()
{
    Console.WriteLine("This is the run-down gas station you were abandoned at. It is in desperate need of repair");
    Console.WriteLine("Illegal items are sold in this store, so the clerk is afraid of calling the police unless ");
    Console.WriteLine("it is a dire emergency.\n");
    if (GeneratePercentage() <= 5)
    {
        RandomEvent();
    }
}
void room2Scenario ()
{
    Console.WriteLine("You have pulled in front of a run down looking house. The old man acompanying you wants you to go ");
    Console.WriteLine("to the front door to get his pain medication. He hands you a $20 bill to purchase the medication with. ");
    Console.WriteLine("You accept the $20, get out of the car, and head to the front door. The transaction goes down without incident.\n");
    if (GeneratePercentage() <= 5)
    {
        RandomEvent();
    }
}

void room3Scenario()
{
    Console.WriteLine("You are in front of an abandoned church. A few women in scant clothing are sitting on the steps. ");
    Console.WriteLine("The old man asks you to see if one of the women will get him more pain medicine.");
    Console.WriteLine("With great trepidation, you approach the women and make your request.");
    Console.WriteLine("One of the women agrees to help and takes the money. After what seems like a long time,");
    Console.WriteLine("the woman returns with some medicine to give to the old man.\n");
    if (GeneratePercentage() <= 5)
    {
        RandomEvent();
    }
}

void room4Scenario()
{
    Console.WriteLine("You turn into a dark alley. There is a long, wooden fence along one side. ");
    Console.WriteLine("A man's head pops up over the fence. The old man asks you to stop so he can say ");
    Console.WriteLine("hello to an old friend. The old man rolls down his window, they talk for a few minutes, ");
    Console.WriteLine("then the old man tells you to move on.\n");
}

void room5Scenario()
{
    Console.WriteLine("You arrive in front of a liquor store. The old man gives you 3 one-dollar bills and some change. ");
    Console.WriteLine("You tell him that he has not given you enough money. The old man educates you that this liquor store ");
    Console.WriteLine("sells small bottles of liquor for $1 each. He would like three small bottle of liquor. You go in ");
    Console.WriteLine("and purchase the alcohol on the old man's behalf.\n");
    if (GeneratePercentage() <= 5)
    {
        RandomEvent();
    }
}
void room6Scenario()
{
    Console.WriteLine("You drive up in front of a small, dark house. The man asks you to wait in the car while he goes ");
    Console.WriteLine("inside to retrieve something. You notice the dome light in the car does not turn on when the car ");
    Console.WriteLine("door opens, as if the man does not want anyone to see inside the car. The man leaves you alone, goes ");
    Console.WriteLine("inside the house, and comes back out carrying a small brown bag.\n");
    if (GeneratePercentage() <= 5)
    {
        RandomEvent();
    }
}

void room7Scenario()
{
    Console.WriteLine("You pull into the parking lot of an auto parts store. It is past normal business hours, ");
    Console.WriteLine("and the store is closed. The old man makes a phone call, and a few minutes later, a loud car ");
    Console.WriteLine("pulls up next to your car. The old man says he will just be a minute. He gets out of the car, ");
    Console.WriteLine("goes to the loud car and gets in. A few minutes later, he returns to your car.\n");
    if (GeneratePercentage() <= 5)
    {
        RandomEvent();
    }
}

void room8Scenario()
{
    Console.WriteLine("You drive into a nice little park. The park is closed and deserted. The old man seems relieved ");
    Console.WriteLine("to have made it here. He tells you he would like a few moments of silence while he takes his ");
    Console.WriteLine("pain meds. He asks you to let him know if someone pulls into the park. He then enjoys getting ");
    Console.WriteLine("some relief to his pain.\n");
    if (GeneratePercentage() <= 5)
    {
        RandomEvent();
    }
}
void room9Scenario()
{
    Console.WriteLine("The car suddenly stops in the middle of the street. You look around, wondering why the old man stopped ");
    Console.WriteLine("at this particular location. He nods his head, and you look in the direction he is nodding towards. ");
    Console.WriteLine("You see police cars and realize you have finally made it to the Police Station. Making it home safe and sound is ");
    Console.WriteLine("a possibility for you.\n");
    if (GeneratePercentage() <= 5)
    {
        RandomEvent();
    }
}

int GeneratePercentage()
{
    return Random.Shared.Next(1, 101);
}

void RandomEvent()
{
    Console.WriteLine("A police car turns onto the road right next to you. The old man becomes visibly nervous and stays that way ");
    Console.WriteLine("until the police turns off onto a side road.\n");
}