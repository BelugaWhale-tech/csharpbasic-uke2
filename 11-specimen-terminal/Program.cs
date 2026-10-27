using System.ComponentModel;
using System.Net.Quic;
using System.Runtime.CompilerServices;

List<string> specimens = new List<string>();

while (true)
{
    Console.Write("Command (ADD/REMOVE/LIST/COUNT/QUIT): ");
    string? command = Console.ReadLine().ToUpper();

    // TODO: Implementer kommandoene.
    // Tips: specimens må IKKE opprettes på nytt inne i løkken.

    if (command == "QUIT")
    {
        break;
    }
    
    else if(command == "COUNT")
    {
        Console.WriteLine(specimens.Count);
    }
    
    else if(command == "LIST")
    {
       foreach(string? i in specimens)
        {
            Console.WriteLine(i);
        }
    }
    
    else if(command == "ADD")
    {
        Console.WriteLine("ADD TO LIST");
        string Listing = Console.ReadLine().ToUpper();
        specimens.Add(Listing);
    }
    
    else if (command == "REMOVE") // remove item uten å kalle remove to ganger
    {
        //SJEKK OM SPECIMEN ER I LISTE, OM TRUE KAN FJERNE.OM FALSE NO EXISITING ENTRY 
        Console.WriteLine("REMOVE FROM LIST");
        string Listing =Console.ReadLine().ToUpper();

        if(!specimens.Contains (Listing))//kunne brukt else her?
        {
            Console.WriteLine("NO EXISTING ENTRY");
            continue;
        }
        specimens.Remove(Listing);
        Console.WriteLine("REMOVED FROM LIST");
    }

    else
    {
    Console.WriteLine("NO VALID ENTRY,TRY AGAIN");
    }



}
