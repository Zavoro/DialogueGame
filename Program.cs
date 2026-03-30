using DialogueGame;

void TypeText(string text)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(40);
    }
    Console.WriteLine();
}
// ask for the name
// store it
// create the player
TypeText("what is your name?");
string name = Console.ReadLine();
Player user = new Player(name);
Thread.Sleep(50);
Console.Clear();
Thread.Sleep(250);

//declare darkRoom object of the Scene class
Scene darkRoom = new Scene("The room is dark.");

//declare mozaicRoom object of the Scene class
Scene mozaicRoom = new Scene("The room has a marble floor with a beautiful mozaic barely visible under candle-light");

// DEBUGGING
// true = skip | false = don't skip
bool skipIntro = true;

if (!skipIntro)
{
    Intro();
}
//jump straight to choice scene
ChoiceScene();

void Intro()
{
    Thread.Sleep(1000);
    TypeText("You wake up, you can't remember how you got here");
    Thread.Sleep(1000);
    Console.Clear();
    TypeText(darkRoom.Description);
    Thread.Sleep(2500);
    Console.Clear();
    TypeText("Hello?");
    Thread.Sleep(2500);
    Console.Clear();
    TypeText("Hello..?");
    Thread.Sleep(2500);
    Console.Clear();
    TypeText("Your vision starts to clear, you see a hooded man in front of you");
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
        string choice = Console.ReadLine().ToLower().Trim();
        switch (choice)
        {
            case "1":
                Console.Clear();
                Thread.Sleep(500);
                TypeText("Don't worry who I am, just know that i mean no danger.");
                mozaicLevel();
                return;

            case "2":
                Console.Clear();
                Thread.Sleep(500);
                TypeText("Well i don't know how you got here, this place is quite far into the woods.");
                mozaicLevel();
                return;

            case "3":
                Console.Clear();
                Thread.Sleep(500);
                TypeText("You're probably wondering where we are, we're quite far into the woods.");
                mozaicLevel();
                return;

            default:
                Console.Clear();
                Thread.Sleep(500);
                TypeText("hm?");
                Thread.Sleep(2000);
                Console.Clear();
                break;

        }
    }
}

void mozaicLevel()
{
    Thread.Sleep(1000);
    Console.Clear();
    TypeText("The old man starts to walk down the hallway");
    Thread.Sleep(500);
    Console.Clear();
    TypeText("You decide to follow him through a doorway");
    Thread.Sleep(500);
    Console.Clear();
    TypeText(mozaicRoom.Description);
}





