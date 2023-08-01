var end = false;

Console.WriteLine("Windows Shutdown Timer by Poltronas\n");

Console.WriteLine("Select an option:\n\n1 - Set timer\n2 - Clear previous timers\n"); //Select desired action
string option = Console.ReadLine();

while (option != "1" && option != "2") //Check for invalid input
{
    Console.WriteLine("\nInvalid input\n");
    option = Console.ReadLine();
}

if (option == "2") //Clears any previous timers
{
    System.Diagnostics.Process.Start("CMD.exe", $"/C shutdown -a");
    Console.WriteLine("Any existing timers were reset\n");
    end = true;
}

while (end == false)
{
    Console.Write("\nEnter time (minutes) until shutdown: "); //Input
    int mins = int.Parse(Console.ReadLine());

    Console.WriteLine($"\nPC will shut down in {mins} minutes.\n\nConfirm?\n"); //Timer confirmation
    Console.WriteLine("1 - Yes\n2 - No\n");
    string confirm = Console.ReadLine();

    while (confirm != "1" && confirm != "2") //Check for invalid confirmation
    {
        Console.WriteLine("\nInvalid input\n");
        confirm = Console.ReadLine();
    }

    if (confirm == "1") // Confirms timer or resets it
    {
        Console.WriteLine($"\nPC will shut down in {mins} minutes.\n");
        System.Diagnostics.Process.Start("CMD.exe", $"/C shutdown -s -t {mins * 60}");
    }
    else continue;

    end = true;
}

Console.WriteLine("Press any key to exit"); //Exits program
Console.ReadKey();