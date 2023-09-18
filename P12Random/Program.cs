
Console.WriteLine("Please pass me a seed");
int seed = int.Parse(Console.ReadLine());
Random random = new Random(seed);
Console.WriteLine("Random numbers between 0 and 5 (inclusive):");
for (int i = 0; i < 3; i++)
{
    int random1 = random.Next(0, 5);
    Console.WriteLine(random1);
}
     

