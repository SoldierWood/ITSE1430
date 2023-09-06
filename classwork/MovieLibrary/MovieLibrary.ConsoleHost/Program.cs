﻿// Movie data:
// Title, genre, description, mpaa rating
// Length, release year, budget
// IsBlackAndWhite
// Operations: Add, edit, view, delete

string title = "", description = "";
//title = "";
string genre = "", rating = "";

int length = 0, releaseYear = 1900;

decimal budget = 125.45M;
bool isBlackAndWhite = false;

GetMovie();
DisplayMovie();

void GetMovie ()
{
    title = ReadString("Enter a title: ", true);
    description = ReadString("Enter a description: ", false);

    length = ReadInt("Enter the run length (in mins): ", 0);
    releaseYear = ReadInt("Enter the release year: ", 1900);

    genre = ReadString("Enter a genre: ", false);
    rating = ReadString("Enter a rating: ", false);

    isBlackAndWhite = ReadBoolean("Black and White (Y/N)?");

    //TODO: Fix length
    
}

void DisplayMovie ()
{
    Console.WriteLine();
    Console.WriteLine("----------------");

    Console.WriteLine(title);
    
    // Run Length: ## mins
    Console.WriteLine("Run Length: " + length + " mins");

    // Released yyyy
    Console.WriteLine("Released " + releaseYear);

    Console.WriteLine(genre);

    // MPAA Rating:
    Console.WriteLine("MPAA Rating: " + rating);

    //Black and White?
    //string format = "Color";
    //if (isBlackAndWhite)
    //    format = "Black and White";

    //V2
    string format = isBlackAndWhite ? "Black and White" : "Color";
    Console.WriteLine("Format: " + format);

    //V3
    //Console.WriteLine("Format: " + (isBlackAndWhite ? "Black and White" : "Color"));

    Console.WriteLine(description);
}

bool ReadBoolean ( string message )
{
    Console.WriteLine(message);

    //Handle errors

    while (true)
    {
        //string value = Console.ReadLine();
        var value = Console.ReadLine();
        if (value == "Y" || value =="y")
            return true;
        else if (value == "N" || value == "n")
            return false;

        Console.WriteLine("Please enter Y/N)");

        ////Stops current iteration, exits loop
        //if (false)
        //    break;

        ////Stops current iteration, loops around and tries again
        //if (false)
        //    continue;
    };
}


int ReadInt ( string message, int minimumValue )
{
    Console.WriteLine(message);

    do
    {
        string value = Console.ReadLine();

        //int result = Int32.Parse(value);

        //int result;
        //if (Int32.TryParse(value, out result))
        if (Int32.TryParse(value, out var result))
            if (result >= minimumValue)
                return result;

        Console.WriteLine("Value must be at least " + minimumValue);
    } while (true);
}


string ReadString(string message, bool isRequired)
{
    Console.WriteLine(message);

    do
    {
        string value = Console.ReadLine();

        if (!isRequired || value != "")
            return value;

        //if (!isRequired)
        //    return value;

        ////Is it empty?
        //if (value != "")
        //    return value;

        Console.WriteLine("Value is required");
    } while (true);
}
