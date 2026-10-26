bool accepted = CanContain(10, 0, 10);

if (accepted)
{
    Console.WriteLine("ACCEPTED");
}
else
{
    Console.WriteLine("REJECTED");
}

static bool CanContain(int capacity, int occupied, int incoming)
{
    // TODO
   return capacity >= occupied + incoming;
   // return false;
}
