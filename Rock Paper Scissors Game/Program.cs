//Declare Variables
Random rand = new Random();
int playerScore = 0;
int computerScore = 0;
int roundsPlayed = 0;
int currentRound = 1;
int numberOfRounds = 5;
bool shouldPlayAgain = true;
string[] gameArt = { 
@"    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)",
@"    _______
---'   ____)____
          ______)
          _______)
         _______)
---.__________)",
@"    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)"
};

Console.WriteLine("Let's play Rock, Paper, Scissors!");
Console.WriteLine("Press enter to start...");
Console.ReadLine();
Console.Clear();

Console.WriteLine("Instructions:");
Console.WriteLine("Rock beats Scissors");
Console.WriteLine("Scissors beats Paper");
Console.WriteLine("Paper beats Rock");
Console.WriteLine($"Best out of {numberOfRounds} wins!!!\n");
Console.WriteLine("Press enter to start the first round...");
Console.ReadLine();
Console.Clear();

while (shouldPlayAgain) {

    Console.WriteLine($"Round {currentRound}");
    Console.WriteLine("Type '0' for rock, '1' for papper or '2' for scissors");
    Console.WriteLine($"Your current score: {playerScore}        Computer's Score {computerScore}");
    int choice = Convert.ToInt32(Console.ReadLine());

    int computerChoice = rand.Next(0, 3);

    switch (choice) {
        case 0:
            Console.WriteLine("You chose Rock!");
            break;
        case 1:
            Console.WriteLine("You chose Paper!");
            break;
        case 2:
            Console.WriteLine("You chose Scissors!");
            break;
        default:
            Console.WriteLine("Invalid choice! Please choose 0, 1, or 2.");
            return;
    }

    Console.WriteLine(gameArt[choice]);
    Console.WriteLine("Computer Chose:");
    Console.WriteLine(gameArt[computerChoice]);

    if (choice == computerChoice) {
        Console.WriteLine("It's a draw!");
    }
    else if ((choice == 0 && computerChoice == 2) ||
               (choice == 1 && computerChoice == 0) ||
               (choice == 2 && computerChoice == 1)) {
        Console.WriteLine("You win!");
        playerScore ++;
    }
    else {
        Console.WriteLine("You lose!");
        computerScore ++;
    }
    if (playerScore == 3 || computerScore == 3) {
        shouldPlayAgain = false;
    }
    else {
        shouldPlayAgain = true;
    }
    Console.WriteLine("Press enter to move to the next round");
    Console.ReadLine();
    Console.Clear();

    currentRound++;
    roundsPlayed++;
}
Console.WriteLine($"Final Score: You {playerScore} - Computer {computerScore}");
Console.WriteLine($"Rounds Played: {roundsPlayed}");
if (playerScore > computerScore) {
    Console.WriteLine("Congratulations! You won the game!");
}
else { 
    Console.WriteLine("Better luck next time! Computer won the game!");
}
