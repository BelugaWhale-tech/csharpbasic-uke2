using System.Runtime.CompilerServices;

List<string> manifest = new List<string> { "LENS", "BATTERY", "FILTER", "CABLE" };

Console.WriteLine(ContainsItem(manifest, "FILTER"));
Console.WriteLine(ContainsItem(manifest, "WRENCH"));

static bool ContainsItem(List<string> items, string search)
{
    // TODO: Søk med løkke.
    
    foreach(string i in items)
    {
        if (search == i)
        {
             return true;
        }
    }

    return false;
}
