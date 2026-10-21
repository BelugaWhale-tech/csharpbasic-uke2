string[] packets = { "P-100", "CORRUPT", "P-101", "P-102", "CORRUPT", "P-103" };
int processedCount = 0;

foreach (string packet in packets)
{
    // TODO: Bruk continue for CORRUPT.
    // TODO: Prosesser resten og øk processedCount.

    // arrays starter på 0, skal jeg skrive slik at processed kommer ut "riktig"?

    if(packet == "CORRUPT")
    {
        continue;
    }
    else
    {
        Console.WriteLine($"Processed...{processedCount++}");
    }

}

Console.WriteLine($"Processed packets: {processedCount}");
