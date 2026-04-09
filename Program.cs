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

//darkRoomChoices List
List<string> darkRoomChoices = new List<string>
{
 "1. Who are you?",
 "2. Where am I?",
 "3. Stay silent."
};


//declare darkRoom object of the Scene class
Scene darkRoomScene = new Scene("The room is dark.", darkRoomChoices);

//mozaicRoomChoices Choices List
List<string> mozaicRoomChoices = new List<string>();

//declare mozaicRoom object of the Scene class
Scene mozaicRoom = new Scene("The room has a marble floor with a beautiful mozaic barely visible under candle-light", mozaicRoomChoices);

// DEBUGGING
// true = skip | false = don't skip
bool skipIntro = true;

if (!skipIntro)
{
    darkRoomLevel();
}
//jump straight to choice scene
ChoiceScene(darkRoomScene);

void darkRoomLevel()
{
    if (!user.HasItem("Candle"))
        {
        Thread.Sleep(1000);
        TypeText("You wake up, you can't remember how you got here");
        Thread.Sleep(1000);
        Console.Clear();
        TypeText(darkRoomScene.Description);
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

    else
        {
        Thread.Sleep(1000);
        TypeText("You walk back into the dark room, your candle gives some light");
        }
    
}

void ChoiceScene(Scene scene)
{
    while (true)
    {
        foreach (string a in scene.Choices)
        {
            TypeText(a);
        }
        string choice = Console.ReadLine().ToLower().Trim();
        switch (choice)
        {
            case "1":
                Console.Clear();
                Thread.Sleep(500);
                TypeText("Don't worry who I am, just know that i mean no danger.");
                user.RecordDecision(DecisionsMade.QuestionedMan);
                mozaicLevel();
                return;

            case "2":
                Console.Clear();
                Thread.Sleep(500);
                TypeText("Well i don't know how you got here, this place is quite far into the woods.");
                user.RecordDecision(DecisionsMade.QuestionedMan);
                mozaicLevel();
                return;

            case "3":
                Console.Clear();
                Thread.Sleep(500);
                TypeText("You're probably wondering where we are, we're quite far into the woods.");
                user.RecordDecision(DecisionsMade.StayedSilent);
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
    
    if (user.CheckDecision(DecisionsMade.QuestionedMan))
    {
        TypeText("You're quite a curious one.");

        //DEBUG CHECK DECISION LOGGING 
        //Console.WriteLine(DecisionsMade.QuestionedMan);
    }

    if (user.CheckDecision(DecisionsMade.StayedSilent))
    {
        TypeText("You seem to be a quiet person");

        //DEBUG CHECK DECISION LOGGING
        //Console.WriteLine(DecisionsMade.StayedSilent);
    }

    Thread.Sleep(1000);
    Console.Clear();
    TypeText("The old man starts to walk down the hallway");
    Thread.Sleep(500);
    Console.Clear();
    TypeText("You decide to follow him through a doorway");
    Thread.Sleep(500);
    Console.Clear();
    TypeText(mozaicRoom.Description);
    Thread.Sleep(1000);
    Console.Clear();
    TypeText("There is a lit candle at the doorway, this could be useful.");
    Thread.Sleep(1000);
    Console.Clear();
    user.AddItem("Candle");
    TypeText("You pick up the candle");
    Thread.Sleep(1000);
    Console.Clear();
    //debug candle item pickup
    //Console.WriteLine(user.HasItem("Candle"));
}

darkRoomLevel();





