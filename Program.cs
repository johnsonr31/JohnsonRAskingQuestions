// Richard Johnson
// 10-18-2022

// Here is where we declare the "playAgain" bool
bool playAgain = true;
bool isNumber;
int wakeTime = 0;

// This while loop will continue looping as long as playAgain is true
Console.Clear();
while(playAgain == true)
{
    Console.WriteLine("Would you like me to ask you some questions?");
    Console.Write("YES or NO: ");
    string yesNo = Console.ReadLine();
    yesNo = yesNo.ToUpper();

    if (yesNo == "NO")
    {
        // This will run if the user types NO
        Console.WriteLine("Goodbye.");
        playAgain = false;
    }
    else if (yesNo == "YES")
    {
        // This will run if the user types YES
        Console.WriteLine("Good.");
        Console.WriteLine("What is your name?");
        Console.Write("Name: ");
        // The user will be asked to input their name. Their input will be stored as a string and converted to be all uppercase
        string name = Console.ReadLine();
        name = name.ToUpper();

        Console.WriteLine(" ");
        Console.WriteLine("Now, what time did you wake up today?");
        Console.Write("Enter the hour you woke up: ");
        string awake = Console.ReadLine();
        isNumber = Int32.TryParse(awake, out wakeTime);

        if(isNumber == true)
        {
            // This will run if the number is valid
            Console.WriteLine($"{wakeTime} AM or PM?");
            Console.Write("Enter AM or PM: ");
            string amPM = Console.ReadLine();
            amPM = amPM.ToUpper();

            if (amPM == "AM" || amPM == "PM")
            {
                // This will run if the player enters AM or PM
                Console.WriteLine($"So your name is {name}, and you woke up at {wakeTime} {amPM}");
                Console.WriteLine(" ");
            }
            else
            {
                // This will run if the player enters anything else
                Console.WriteLine("Invalid input");
            }
        }
        else
        {
            // This will run if the user inputs anything that isn't a valid number
            Console.WriteLine("Invalid Input");
        }
        

    }
    else
    {
        // This will run if the user types anything aside from YES or NO
        Console.WriteLine("Invalid Input");
    }
}