// Richard Johnson
// 10-18-2022

// Here is where we declare the "playAgain" bool
bool playAgain = true;
bool isNumber;
bool isNumber2;
int wakeTime = 0;
int wakeMinute = 0;
int hourLengthMax = 1;
int inputHourLength;
int inputMinuteLength;
int minuteLengthMax = 2;
string digits = "1234567890";

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
        Console.Write("Enter the hour you woke up (use 1 digit): ");
        string awake = Console.ReadLine();
        // After the user's input is taken, the code below will validate that their input is a number, and convert it to an int
        isNumber = Int32.TryParse(awake, out wakeTime);
        inputHourLength = awake.Length;

        if(isNumber == true && inputHourLength == hourLengthMax) 
        {
            Console.WriteLine(" ");
            Console.Write("Now enter the minutes of the time you woke up (use 2 digits): ");
            string minutes = Console.ReadLine();
            isNumber2 = Int32.TryParse(minutes, out wakeMinute);
            inputMinuteLength = minutes.Length;
                if(isNumber2 == true && inputMinuteLength == minuteLengthMax)
                {
                    // This will run if the number is valid
                    Console.WriteLine($"{wakeTime}:{wakeMinute} AM or PM?");
                    Console.Write("Enter AM or PM: ");
                    string amPM = Console.ReadLine();
                    amPM = amPM.ToUpper();

                        if (amPM == "AM" || amPM == "PM")
                        {
                        // This will run if the player enters AM or PM
                        Console.WriteLine($"So your name is {name}, and you woke up at {wakeTime}:{wakeMinute} {amPM}.");
                        Console.WriteLine("Hopefully you got enough sleep.");
                        Console.WriteLine(" ");
                        }
                        else
                        {
                        // This will run if the player enters anything else
                        Console.WriteLine("Invalid input");
                        Console.WriteLine(" ");
                        }
                }
                else
                {
                    // This will run if the user entered something that isn't a number
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine(" ");
                }


            
        }
        else
        {
            // This will run if the user inputs anything that isn't a valid number
            Console.WriteLine("Invalid Input");
            Console.WriteLine(" ");
            
        }
        

    }
    else
    {
        // This will run if the user types anything aside from YES or NO
        Console.WriteLine("Invalid Input");
        Console.WriteLine(" ");
    }
}