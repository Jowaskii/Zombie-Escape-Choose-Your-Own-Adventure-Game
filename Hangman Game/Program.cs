//Declare Variables

List<string> wordList = new List<string>() { "apple", "banana", "strawberry", "grapefruit", "watermelon", "peach", "pear", "kiwi", "mango", "pineapple","blueberry","lemon","orange" };
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
    Console.WriteLine(hangmanStages[lives]);
    foreach (char letter in chosenWord) {
        placeholdText += "_";
    }
    Console.WriteLine(placeholdText);
    while (!isGameOver) {
        displayWord = string.Empty;
        Console.WriteLine("Guess a letter: ");
        userGuess = Console.ReadKey().KeyChar;
        char skipper = char.MinValue;
       
        foreach (char letter in chosenWord) {
            if (letter == userGuess) {
                displayWord += userGuess;
                correctLetters.Add(userGuess);
                guessedLetters.Add(userGuess);
            }
            else if (correctLetters.Contains(letter)) {
                displayWord += letter;
            }
            else {
                displayWord += "_";
            }
        }
    

        if (!chosenWord.Contains(userGuess)) {
      
            if (guessedLetters.Contains(userGuess)) {
                Console.WriteLine("You've already guessed that letter");
                skipper = Console.ReadKey().KeyChar;
            }
            else {
                guessedLetters.Add(userGuess);
                lives--;
            }
        }
            
        Console.Clear();
        Console.WriteLine(hangmanStages[lives]);
        Console.WriteLine(displayWord);
        if (!displayWord.Contains("_")) {
            Console.WriteLine("Congratulations! You guessed the word!");
            isGameOver = true;
        }
        else if (lives == 0) {
            Console.WriteLine("Game Over! The word was: " + chosenWord);
            isGameOver = true;
        }
    }
    Console.WriteLine("Do you want to play again? (y/n)");
    string playAgain = Console.ReadLine().ToLower();
    if (playAgain == "y") {
        Console.Clear();
        StartGame();
    }
}
StartGame();