using System.ComponentModel.Design;

Console.WriteLine("What's your age?");

int age = int.Parse(Console.ReadLine()!);

if (age <= 12) 
{
Console.WriteLine("awww you are a child HAHAHAHA");
    
}
else if (age <= 19) 

{
    Console.WriteLine("Not bad, you are a teenager"); 
}
else
{
    Console.WriteLine("you are an adult");
}
Console.WriteLine("give me another integer ");

int number1 = int.Parse(Console.ReadLine());

int maximum = number1 > age ? number1 : age; 

Console.WriteLine("The maximum is: " + maximum);
if (maximum % 2 == 0)
{
    Console.WriteLine("It's an even number.");
}
else
{
    Console.WriteLine("It's an odd number.");
}




