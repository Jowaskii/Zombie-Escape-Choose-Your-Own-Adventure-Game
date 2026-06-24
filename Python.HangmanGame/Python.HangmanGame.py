import random
import os


word_list = ["apple", "bat","associate"]
chosen_word = random.choice(word_list)
placeholder_text = ""
correct_guesses = []

game_over = False

print('''  
 _                                             
| |                                            
| |__   __ _ _ __   __ _ _ __ ___   __ _ _ __  
| '_ \ / _` | '_ \ / _` | '_ ` _ \ / _` | '_ \ 
| | | | (_| | | | | (_| | | | | | | (_| | | | |
|_| |_|\__,_|_| |_|\__, |_| |_| |_|\__,_|_| |_|
                    __/ |                      
                   |___/ ''')
input("Press Enter to Continue")
os.system('cls')

print(word_list)
print(chosen_word)
for letter in chosen_word:
    placeholder_text += "_"
print(placeholder_text)
while not game_over:
    display_text = ""
    print(correct_guesses)
    guess = input("Please guess a letter: ").lower()
    for letter in chosen_word:
        if letter == guess:
            display_text += letter
            if letter not in correct_guesses:
                correct_guesses += letter
        else:
            display_text += "_"
    print(display_text)