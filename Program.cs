void TypeText(string text)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(40);
    }
    Console.WriteLine();
}
// DEBUGGING
// True = skip | False = don't skip
bool skipIntro = false;

if  (!skipIntro)
{
    Intro();
}
//jump straight to choice scene
ChoiceScene();

void Intro()
{
    Thread.Sleep(1000);
    TypeText("You wake up in a dark room, you can't remember how you got here");
    Thread.Sleep(2500);
    Console.Clear();
    TypeText("Hello?");
    Thread.Sleep(2500);
    Console.Clear();
    TypeText("Hello..?");
    Thread.Sleep(2500);
    Console.Clear();
    TypeText("Your vision starts to clear up, you see a hooded man in front of you");
    Thread.Sleep(1500);
}


void ChoiceScene()
{
    while (true)
    {
        TypeText(@"1. Who are you?
2. Where am i?
3. Stay Silent.
           ");
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            Console.Clear();
            Thread.Sleep(500);
            TypeText("Don't worry who I am, just know that i mean no danger.");
            break;
        }
        else if (choice == "2")
        {
            Console.Clear();
            Thread.Sleep(500);
            TypeText("Well i don't know how you got here, this place is quite far into the woods.");
            break;
        }
        else if (choice == "3")
        {
            Console.Clear();
            Thread.Sleep(500);
            TypeText("You're probably wondering where we are, we're quite far into the woods.");
            break;
        }
        else
        {
            Console.Clear();
            Thread.Sleep(500);
            TypeText("hm?");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }

}





