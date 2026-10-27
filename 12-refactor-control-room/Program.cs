List<string> beacons = new List<string>();


while (true)
{
    PrintMenu();
    string? choice = Console.ReadLine();

    if (choice == "1")
    {
        AddBeacon();
    }
    else if (choice == "2")
    {
        RemoveBeacon();
    }
    else if (choice == "3")
    {
        ListBeacons();
    }
    else if (choice == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Unknown choice.");
    }
}


 void PrintMenu()
{
    Console.WriteLine();
    Console.WriteLine("1 - Add beacon");
    Console.WriteLine("2 - Remove beacon");
    Console.WriteLine("3 - List beacons");
    Console.WriteLine("4 - Quit");
    Console.Write("Choice: ");
}

void AddBeacon()
{
    Console.Write("Beacon name: ");
        string? name = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(name))
        {
            beacons.Add(name);
            Console.WriteLine("Beacon added.");
        }
}

void RemoveBeacon()
{
    Console.Write("Beacon name: ");
        string? name = Console.ReadLine();
        if (name is not null && beacons.Remove(name))
        {
            Console.WriteLine("Beacon removed.");
        }
        else
        {
            Console.WriteLine("Beacon not found.");
        }
}
void ListBeacons()
{
    if (beacons.Count == 0)
        {
            Console.WriteLine("No beacons registered.");
        }
        else
        {
            foreach (string beacon in beacons)
            {
                Console.WriteLine($"- {beacon}");
            }
        }
}