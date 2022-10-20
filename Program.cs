// Richard Johnson
// 10-18-2022

// Here is where we declare the "playAgain" bool
bool playAgain = true;
bool isNumber;
bool isNumber2;
bool time;
bool nameNum = true;
int num = 0;
int wakeTime = 0;
int hourLengthMax = 2;
int inputHourLength;
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
        // The user will be asked to input their name. Their input will then be stored as a string to be printed later
        
        while(nameNum == true)
        {
        string name = Console.ReadLine();
        // name = name.ToUpper();
        isNumber = Int32.TryParse(name, out num);

            if(isNumber != true)
            {
                nameNum = false;
                Console.WriteLine(" ");
                Console.WriteLine("Now, what time did you wake up today?");
                time = true;
                while(time == true)
                {
                Console.Write("Enter the hour you woke up (Standard Time): ");
                string awake = Console.ReadLine();
                // After the user's input is taken, the code below will validate that their input is a number, and convert it to an int
                isNumber = Int32.TryParse(awake, out wakeTime);
                inputHourLength = awake.Length;

                if(isNumber == true && inputHourLength <= hourLengthMax) 
                {
                // If the user's input is a valid number, their number will be printed, and they will be asked to input AM or PM
                Console.WriteLine($"{wakeTime} AM or PM?");
                Console.Write("Enter AM or PM: ");
                string amPM = Console.ReadLine();
                amPM = amPM.ToUpper();

                if (amPM == "AM" || amPM == "PM")
                {
                    // If the user enters AM or PM, the program will print the user's input to the console
                    Console.WriteLine($"So your name is {name}, and you woke up at {wakeTime} {amPM}.");
                    Console.WriteLine("Hopefully you got enough sleep.");
                    Console.WriteLine(" ");
                    time = false;
                }
                else
                {
                    // If the player enters anything else, the loop will start again
                    Console.WriteLine("Invalid input");
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
            }
            else
            {
                Console.WriteLine("That is a number.");
                Console.Write("Please Enter a name: ");
            }
        }
            

        
        

    }
    else
    {
        // This will run if the user types anything aside from YES or NO
        Console.WriteLine("Invalid Input");
        Console.WriteLine(" ");
    }
}