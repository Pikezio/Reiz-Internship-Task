OutputPrompt();

// Program repeats, until "exit" is typed.
string input;
while((input = Console.ReadLine()) != "exit")
{
    CalculateTime(input);
    OutputPrompt();
}

// Prompt for the user
static void OutputPrompt()
{
    Console.WriteLine("Please input the time (HH:mm) :");
    Console.WriteLine("Type \"exit\" to quit.");
}

static void CalculateTime(string input)
{
    if (input != "")
    {
        // Split time into hours and minutes
        var parts = input.Split(":");
        try
        {
            // String to Int conversion
            int hours = Convert.ToInt32(parts[0]);
            int minutes = Convert.ToInt32(parts[1]);

            // Checks if numbers are in the correct range
            if (hours > 23 || hours < 0)
                Console.WriteLine("Error, wrong hour input: " + hours);
            else if (minutes > 59 || minutes < 0)
                Console.WriteLine("Error, wrong minute input: " + minutes);
            else
            {
                // Changes hours from 24h to 12h format
                if (hours > 12)
                    hours -= 12;

                // Angle calculation
                int angleBetween = Math.Abs((30 * hours - 11 * minutes / 2));

                // Checking against the other angle
                int lesserAngle = Math.Min(angleBetween, 360 - angleBetween);
                Console.WriteLine("The lesser angle is: " + lesserAngle + " degrees");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Error, bad input");
        }
    }
    else
        Console.WriteLine("Error, no input.");
    Console.WriteLine();
}
