// Lab 1 Adventure Game
// Written by Chris Wood
// Fall 2023


// Entry point
int currentRoom = 1;
//int newRoom = 0;

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
        if (!Confirmation("Are you sure you want to quit the game (Y/N/?"))
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
    if (currentRoom == 1)
    {
        Console.WriteLine("You cannot move North from the gas station. Please try a different direction.\n");
    }

    return currentRoom;
}

int MoveSouth ( int currentRoom )
{

    return currentRoom;
}

int MoveEast (int currentRoom)
{
    //int roomNew = currentRoom;

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

    return currentRoom;

}

int MoveWest (int currentRoom)
{
    if (currentRoom == 1)
    {
        Console.WriteLine("You cannot move West from the gas station. Please try a different direction.\n");
    }

    return currentRoom;
}

void room2Scenario ()
{
    Console.WriteLine("You have pulled in front of a run down looking house. The old man acompanying you wants you to go ");
    Console.WriteLine("to the front door to get his pain medication. He hands you a $20 bill to purchase the medication with. ");
    Console.WriteLine("You accept the $20, get out of the car, and head to the front door. The transaction goes down without incident.\n");
}

void room3Scenario()
{
    Console.WriteLine("You are in front of an abandoned church. A few women in scant clothing are sitting on the steps. ");
    Console.WriteLine("The old man asks you to see if one of the women will get him more pain medicine.");
    Console.WriteLine("With great trepidation, you approach the women and make your request.");
    Console.WriteLine("One of the women agrees to help and takes the money. After what seems like a long time,");
    Console.WriteLine("the woman returns with some medicine to give to the old man.");
}