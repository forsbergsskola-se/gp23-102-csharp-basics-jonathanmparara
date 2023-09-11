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
    Console.WriteLine("give me another number");

int number1 = int.Parse(Console.ReadLine());

int number2 = age;

if (number1 > number2)
{
    Console.WriteLine(" The number is greater than your age");
}
else if (number1 < number2)
{
    Console.WriteLine("your age is greater than the number");
}
else
{
    Console.WriteLine("The number and your age 12 are equal");
}

if 


