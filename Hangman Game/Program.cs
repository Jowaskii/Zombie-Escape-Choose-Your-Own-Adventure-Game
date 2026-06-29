//Declare Variables

using System.Diagnostics.Metrics;

List<string> wordList = new List<string>() { "apple", "banana", "strawberry", "grapefruit", "watermelon", "peach", "pear", "kiwi", "mango", "pineapple","blueberry","lemon","orange","pumpkin" };
List<char> guessedLetters = new List<char>();
List<char> correctLetters = new List<char>();
string[] hangmanStages = new string[]
{ @"  +---+
  |   |
  O   |
 /|\  |
 / \  |
      |
=========",
@"  +---+
  |   |
  O   |
 /|\  |
 /    |
      |
=========",
@"  +---+
  |   |
  O   |
 /|\  |
      |
      |
=========",
@"  +---+
  |   |
  O   |
 /|   |
      |
      |
=========",
@"  +---+
  |   |
  O   |
  |   |
      |
      |
=========",
@"  +---+
  |   |
  O   |
      |
      |
      |
=========",
@"  +---+
  |   |
      |
      |
      |
      |
=========" };
string placeholdText = string.Empty;
string chosenWord = string.Empty;
string displayWord = string.Empty;
char userGuess =char.MinValue;

int lives = int.MinValue;
int score = 0;

Random rand = new Random();
bool isGameOver = false;

Console.WriteLine(@"
 _                                             
| |                                            
| |__   __ _ _ __   __ _ _ __ ___   __ _ _ __  
| '_ \ / _` | '_ \ / _` | '_ ` _ \ / _` | '_ \ 
| | | | (_| | | | | (_| | | | | | | (_| | | | |
|_| |_|\__,_|_| |_|\__, |_| |_| |_|\__,_|_| |_|
                    __/ |                      
                   |___/ 
");
Console.WriteLine("Press Enter To Start!");
Console.ReadLine();
Console.Clear();

void Reset() {
    isGameOver = false;
    int randomIndex = rand.Next(wordList.Count);
    correctLetters = [];
    guessedLetters = [];
    placeholdText = string.Empty;
    chosenWord = wordList[randomIndex];
    lives = hangmanStages.Length - 1;
}
void StartGame() {
    Reset();
    DisplayScoreAndVisual();
    foreach (char letter in chosenWord) {
        placeholdText += "_";
    }
    Console.WriteLine(placeholdText);
    while (!isGameOver) {

        displayWord = string.Empty;
        Console.WriteLine("Guess a letter: ");
        userGuess = Console.ReadKey().KeyChar;
        char skipper = char.MinValue;

        if (!guessedLetters.Contains(userGuess) && !chosenWord.Contains(userGuess)) {
            lives--;
        }
        if (!guessedLetters.Contains(userGuess)) {
            {
                guessedLetters.Add(userGuess);
            }
        }
        else if (guessedLetters.Contains(userGuess)) {
            Console.Clear();
            DisplayScoreAndVisual();
            Console.WriteLine("You've already guessed that letter");
            skipper = Console.ReadKey().KeyChar;
        }

        foreach (char letter in chosenWord) {
            if (letter == userGuess) {
                displayWord += userGuess;
                correctLetters.Add(userGuess);
            }
            else if (correctLetters.Contains(letter)) {
                displayWord += letter;
            }
            else {
                displayWord += "_";
            }
        }

        Console.Clear();
        DisplayScoreAndVisual();
        Console.WriteLine(displayWord);

        if (!displayWord.Contains("_")) {
            Console.WriteLine("Congratulations! You guessed the word!");
            isGameOver = true;
            score += 5;
        }
        else if (lives == 0) {
            Console.WriteLine("Game Over! The word was: " + chosenWord);
            Console.WriteLine($"Final Score: {score}");
            score = 0;
            isGameOver = true;
        }
    }
    Console.WriteLine("Do you want to play again? (y/n)");
    char playAgain = Console.ReadKey().KeyChar;
    if (playAgain == 'y') {
        Console.Clear();
        StartGame();
    }
}
void DisplayScoreAndVisual() {
    Console.WriteLine("Score: " + score);
    Console.WriteLine(hangmanStages[lives]);
}    
StartGame();
