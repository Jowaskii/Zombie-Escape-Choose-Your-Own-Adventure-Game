// See https://aka.ms/new-console-template for more information
string bedroomScene = string.Empty;
void PrintTitleScreen()
{
    Console.WriteLine("" +
        " * ******************************************************************************\r\n" +
        "                          .-\"L\"-.  \r\n" +
        "                            \r\n" +
        "          .--\"\"L\"\"---___    J  |  |\r\n" +
        "          J    J        \"\"L  L J  J              J----\"\"\"J\"\"---__\r\n" +
        "           |    |         J  J  L  L_--\"\"|\"--L   |       F      J\r\n" +
        "            L    L__ ___   L  L |  J     |   J   F      J       F\r\n" +
        "         \\\"\"\"\"\"\"\"   |   \"\"\"\"\"-----, L    |   J  J       F      |\r\n" +
        "          \\          L            L L    |   |  |      J      J      _.---\"\"\"\r\n" +
        "           \\         J            | |    |   |  F      F      F     /\r\n" +
        "            \\         |           J |    |   | J      J      |     /\r\n" +
        "             \\         L      ___---++...;.++'--__    F     J     /\r\n" +
        "              \\        J      L\"\"----____ __---\"\"J__--=----_E_   /\r\n" +
        "               \\        |     J          |       |--__   __--\"/ /\r\n" +
        "          __    \\        L     L         |       F    \"\"F    / /\r\n" +
        "            \"\"\"--__      J     J         |      J      |    / /\r\n" +
        "                   \"\";    |     L        |      |     J    / /\r\n" +
        "              __--\"\"\" \\    L    J        |      F     F   / /\r\n" +
        "        __--\"\"         \\   J     L       |     J     |   / /\r\n" +
        "    --\"\"                \\   |    J       |     |    J   / /\r\n" +
        "                         \\   L    L      |     F    F  / /\r\n" +
        "                          \\  J    J      |    J    |  / /\r\n" +
        "                           \\  |    L     |    |   J  / /\r\n" +
        "                            \\  L   J     |    F   F / /\r\n" +
        "                             \\ J    L    |   J   | / /\r\n" +
        "                              \\ |  _J    |   |\"-J+' /\r\n" +
        "                               \\-L\"  L   |   F     /\r\n" +
        "                                \\    J   |  J     /\r\n" +
        "        '-.                      \\    \"-.|+'     /\r\n" +
        "           '-.                    \\             /                   .\r\n" +
        "              '-.                  \\           /                 .-'\r\n" +
        "                 '-.             .-'            \"-.           .-'\r\n" +
        "                hs  '-.       .-'        .         \"-.     .-'\r\n" +
        "                       '-. .-'         .' '.          '-.-'\r\n" +
        "                          '          .'     '.\r\n" +
        "    \r\n" +
        "    *******************************************************************************");
    Console.WriteLine("Welcome to Zombie Escape!");
    Console.WriteLine("In this game, you will make choices to survive a zombie apocalypse.");
    Console.WriteLine("Good luck!");
    Console.WriteLine("Press Enter to start...");
    Console.ReadLine();
}

PrintTitleScreen();
Console.Clear();
//Console.WriteLine("You wake up in a small, dimly lit room. You can hear the groans of zombies outside. What do you do?");

//Player wakes up and sees zombies outside their apartment window
Console.WriteLine("You wake up and hear screaming outside your apartment window!\nYou look outside in horror as chaos unfolds in front of you, " +
    "crashed cars screaming civilians being attacked and torn to pieces.\n" +
    "The once beautiful Point Guard City is being over-runed by zombies!! YOU MUST ESCAPE");
Console.WriteLine("Press Enter to continue...");
Console.ReadLine();
Console.Clear();

//Openning choice
Console.WriteLine("\"You:\"I've Got to get out of here... Staying here would be a death sentence for sure...\"\nWhere do I go?\"");
Console.WriteLine("Hospital<<<< | >>>> Police Station\nType \"left\" to go the hospital or \"right\" to go to the police station");
string choice1 = Console.ReadLine().ToLower();
if (choice1 == "left")
{
    //Hospital storyline
    Console.WriteLine("You decide to go to the hospital, hoping to find medical supplies and maybe even some survivors.");
    Console.WriteLine("Press Enter to Continue");
    Console.ReadLine();
    Console.WriteLine("You Get to the hospital... The front door is locked. Luckily, you enter through a broken window on the side of the building");
    Console.ReadLine();
    Console.WriteLine("You: \"This place looks even creepier at night\"");
    Console.WriteLine("");
    // Continue with the hospital storyline...
}
else if (choice1 == "right")
{
    //Police station storyline
    Console.WriteLine("You decide to go to the police station, hoping to find weapons and maybe even some survivors.");
    // Continue with the police station storyline...
}
else
{
    Console.WriteLine("Invalid choice. Please type \"left\" or \"right\"");
    // You can choose to loop back to the choice or end the game here.
}
