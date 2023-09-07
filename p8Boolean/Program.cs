Console.WriteLine("What's your age?");

int age = int.Parse(Console.ReadLine());

bool isChild = age < 13;
Console.WriteLine($"you are a child:{isChild}"); // Console.WriteLine("you are a child" + isChild);

bool isTeenager = age >= 13 && age <= 19; 

Console.WriteLine($"you are a teenager:{isTeenager}");// Console.WriteLine("you are a teenager" + isTeenager);

bool isGrownUp = age > 19; 
Console.WriteLine($" look at you all grown up:{isGrownUp}"); // Console.WriteLine(" look at you all grown up" + isGrownUp);
    
    //@ is used to ade ne lines to a string and \n

    //$ is used when putting a variabel into a sentence
    