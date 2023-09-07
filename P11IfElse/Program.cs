using System.ComponentModel.Design;

Console.WriteLine("What's your age?");

int age = int.Parse(Console.ReadLine()!);

if (age < 12) 
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
    



