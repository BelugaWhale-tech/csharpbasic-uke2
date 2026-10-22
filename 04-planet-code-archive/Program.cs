string[] planetCodes = { "ORION-4", "KAPPA-9", "LYRA-2", "NOVA-7", "VEGA-3" };
bool found = false;

// TODO: Skriv Length, første og siste element.
// TODO: Finn KAPPA-9 med en løkke.

Console.WriteLine(planetCodes.Length);
foreach(string planetCode in planetCodes)
{
    if (planetCode == "KAPPA-9")
    {
        found=true;
    }

    
}

Console.WriteLine($"first of array:" +planetCodes[0]);
Console.WriteLine($"last of array:" +planetCodes[planetCodes.Length-1]); // vil altid lese den siste i array, selvom det skulle bli endringer

Console.WriteLine($"Found KAPPA-9: {found}");
