
using DailyIncome;
using System.Text.Json.Serialization;

WritelineColor(ConsoleColor.Magenta, "Welcome in Daily Wages Count System!");

bool EndApp = false;

while (!EndApp)
{
    Console.WriteLine();
    WritelineColor(ConsoleColor.Cyan,
        "1 - Add wages to memory and show daily statistics\n" +
        "2 - Add wages to the .txt file and show daily statistics\n" +
        "X - Close app\n");

    WritelineColor(ConsoleColor.Yellow, "What you want to do? \nPress key 1, 2 or X: ");
    var userInput = Console.ReadLine().ToUpper();

    switch (userInput)
    {
        case "1":
            AddWagesToMemory();
            break;

        case "2":
            AddWageToTxtFile();
            break;

        case "X":
            EndApp = true;
            break;

        default:
            WritelineColor(ConsoleColor.Red, "Invalid operation.\n");
            continue;
    }
}
WritelineColor(ConsoleColor.DarkYellow, "\n\n Press any key to close app.");
Console.ReadKey();


static void WageAdded(object sender, EventArgs args)
{
    Console.WriteLine("Congrats,You added new Wage ");
}
static void WritelineColor(ConsoleColor color, string text)
{
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();
}

static string GetValueFromUser(string comment)
{
    WritelineColor(ConsoleColor.Yellow, comment);
    string userInput = Console.ReadLine();
    return userInput;
}

static void AddWagesToMemory()
{
    string cityName = GetValueFromUser("Please insert city Name: ");
    if (!string.IsNullOrEmpty(cityName))
    {
        var job = new JobInMemory(cityName);
        job.WageAdded += WageAdded;
        EnterWage(job);
        job.ShowStatistics();

    }
    else
    {
        WritelineColor(ConsoleColor.Red, "City Name can't be empty ");
        AddWagesToMemory();
    }
}

static void AddWageToTxtFile()
{
    string cityName = GetValueFromUser("Please insert city Name: ");
    if (!string.IsNullOrEmpty(cityName))
    {
        var job = new JobInFile(cityName);
        job.WageAdded += WageAdded;
        EnterWage(job);
        job.ShowStatistics();
    }
    else
    {
        WritelineColor(ConsoleColor.Red, "City Name can't be empty ");
        AddWageToTxtFile();
    }
}

static void EnterWage(IJob job)
{
    while (true)
    {
        WritelineColor(ConsoleColor.Yellow, $"Enter  Wage to add for city: {job.CityName} or q to exit");
        var input = Console.ReadLine();
        if (input == "q" || input == "Q")
        {
            break;
        }

        try
        {
            job.AddWage(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
        finally
        {
            WritelineColor(ConsoleColor.DarkMagenta, $"To leave and show  statistics enter 'q'.");
        }
    }
}
