using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    // Ask a question
    MooseQuestion("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
    MooseQuestion("Are you enthusiastic?", "Yay!", "You should try it!");
    MooseQuestion("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
    MooseQuestion("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
}


void MooseQuestion(string question, string yesResponse, string noResponse)
{
    bool isYes = MooseAsks(question);
    if (isYes)
    {
        MooseSays(yesResponse);
    }
    else
    {
        MooseSays(noResponse);
    }
}

//bool sets a const that will return a boolean
//string sets a const that will be a string
bool MooseAsks(string question)
{
    //$ sting interpolation
    //question is a parameter
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    //conditionals
    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

//void means method will not return anything
//string sets a const and says the value will be in the form of a string
void MooseSays(string message)
{
    //we add an @ in front of the string to allow for a multi-line string
    //$ enables string interpolation
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}