using System.Data;
using System.Data.Common;

while (true)
{
    Console.Write("Command: ");
    string command = Console.ReadLine();

    // TODO: Avslutt med break når command er EXIT eller null.
    // TODO: Ellers skriv Received: <command>.
    
    if (command == "EXIT")
        {
            break;
        }
    if(command == "")
    {
        Console.WriteLine("Please just write EXIT");
    }

    else
    {
        Console.WriteLine($"RECEIVED: {command}");
    }

}   


Console.WriteLine("Receiver stopped.");
