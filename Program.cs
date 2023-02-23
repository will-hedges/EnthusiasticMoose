using System;
using System.Collections.Generic;

Main();

void Main()
{
    Console.Write(
        $@"
    Welcome to the Enthusiastic Moose Simulator!
    --------------------------------------------
    "
    );

    // display the moose
    MooseSays("Ask me anything!");
    MagicMoose();

    // LEAVING THIS ZOMBIE CODE FOR MY OWN REFERENCE

    // // Let the moose speak!
    // MooseSays("H I, I'M  E N T H U S I A S T I C !");
    // MooseSays("I really am enthusiastic");

    // // Ask some questions
    // MooseAsks("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
    // MooseAsks("Are you enthusiastic?", "Yay!", "You should try it!");
    // MooseAsks(
    //     "Do you love C# yet?",
    //     "Good job sucking up to your instructor!",
    //     "You will...oh, yes, you will..."
    // );
    // MooseAsks(
    //     "Do you want to know a secret?",
    //     "ME TOO!!!! I love secrets...tell me one!",
    //     "Oh, no...secrets are the best, I love to share them!"
    // );
}

void MooseSays(string message)
{
    Console.Write(
        $@"
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
    "
    );
}

// LEAVING THIS ZOMBIE CODE FOR MY OWN REFRENCE

// void MooseAsks(string question, string affirmativeResponse, string negativeResponse)
// {
//     Console.Write($"{question} (Y/N): ");
//     string answer = Console.ReadLine().ToLower();

//     while (answer != "y" && answer != "n")
//     {
//         Console.Write($"{question} (Y/N): ");
//         answer = Console.ReadLine().ToLower();
//     }

//     if (answer == "y")
//     {
//         MooseSays(affirmativeResponse);
//     }
//     else
//     {
//         MooseSays(negativeResponse);
//     }
// }


void MagicMoose()
{
    List<string> responses = new List<string>()
    {
        "As I see it, yes.",
        "Ask again later.",
        "Better not tell you now.",
        "Cannot predict now.",
        "Concentrate and ask again.",
        "Don’t count on it.",
        "It is certain.",
        "It is decidedly so.",
        "Most likely.",
        "My reply is no.",
        "My sources say no.",
        "Outlook not so good.",
        "Outlook good.",
        "Reply hazy, try again.",
        "Signs point to yes.",
        "Very doubtful.",
        "Without a doubt.",
        "Yes.",
        "Yes – definitely.",
        "You may rely on it."
    };

    Random r = new Random();

    while (true)
    {
        Console.Write($"Enter your question: ");
        string answer = Console.ReadLine();
        if (answer != "")
        {
            int randomIdx = r.Next(20);
            MooseSays(responses[randomIdx]);
        }
        else
        {
            // good explanation on why to exit like this: https://stackoverflow.com/a/10286091/13615436
            Environment.Exit(0);
        }
    }
}
