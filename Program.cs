bool keepPlaying = true;
Console.Write("Please Enter Player One's Name: ");
string playerOne = Console.ReadLine();
Console.WriteLine("Welcome " + playerOne + "! You will be X.");
Console.ReadKey(true);
Console.Write("Please Enter Player Two's Name: ");
string playerTwo = Console.ReadLine();
Console.WriteLine("Welcome " + playerTwo + "! You will be O.");
Console.WriteLine("Press any key to contine.");
Console.ReadKey(true);


while (keepPlaying)
{
    string A1 = "_";
    string B1 = "_";
    string C1 = "_";
    string A2 = "_";
    string B2 = "_";
    string C2 = "_";
    string A3 = " ";
    string B3 = " ";
    string C3 = " ";
    bool gameConclusion = false;
    bool playerOneTurn = true;

    while (gameConclusion == false)
    {
        if ((A1 == "O" && B1 == "O" && C1 == "O") || (A1 == "O" && A2 == "O" && A3 == "O") || (A1 == "O" && B2 == "O" && C3 == "O") ||
            (A2 == "O" && B2 == "O" && C2 == "O") || (B1 == "O" && B2 == "O" && B3 == "O") || (A3 == "O" && B2 == "O" && C1 == "O") ||
            (A3 == "O" && B3 == "O" && C3 == "O") || (C1 == "O" && C2 == "O" && C3 == "O"))
        {
            Console.WriteLine("  A B C \n1 " + A1 + "|" + B1 + "|" + C1 + "\n2 " + A2 + "|" + B2 + "|" + C2 + "\n3 " + A3 + "|" + B3 + "|" + C3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(playerTwo + " wins!");
            Console.ResetColor();
            gameConclusion = true;
            Console.WriteLine("Would you like to play again? ('Y' or 'N')");
            string response = Console.ReadLine();
            if (response == "n" || response == "N")
            {
                keepPlaying = false;
            }
        }

        else if (A1 != "_" && B1 != "_" && C1 != "_" && A2 != "_" && B2 != "_" && C2 != "_" && A3 != " " && B3 != " " && C3 != " ")
        {
            Console.WriteLine("  A B C \n1 " + A1 + "|" + B1 + "|" + C1 + "\n2 " + A2 + "|" + B2 + "|" + C2 + "\n3 " + A3 + "|" + B3 + "|" + C3);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("It's a tie!");
            Console.ResetColor();
            gameConclusion = true;
            Console.WriteLine("Would you like to play again? ('Y' or 'N')");
            string response = Console.ReadLine();
            if (response == "n" || response == "N")
            {
                keepPlaying = false;
            }
        }

        else
        {
            while (playerOneTurn)
            {
                Console.WriteLine("  A B C \n1 " + A1 + "|" + B1 + "|" + C1 + "\n2 " + A2 + "|" + B2 + "|" + C2 + "\n3 " + A3 + "|" + B3 + "|" + C3);
                Console.WriteLine(playerOne + "'s turn. Enter your respose like your playing Bingo! Example: a1");
                string playerOneResponse = Console.ReadLine();

                if (playerOneResponse == "a1")
                {
                    if (A1 != "_")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This spot is already taken. Please choose a different spot.");
                        Console.ResetColor();
                    }
                    else
                    {
                        A1 = "X";
                        playerOneTurn = false;
                    }
                }

                else if (playerOneResponse == "b1")
                {
                    if (B1 != "_")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This spot is already taken. Please choose a different spot.");
                        Console.ResetColor();
                    }
                    else
                    {
                        B1 = "X";
                        playerOneTurn = false;
                    }
                }

                else if (playerOneResponse == "c1")
                {
                    if (C1 != "_")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This spot is already taken. Please choose a different spot.");
                        Console.ResetColor();
                    }
                    else
                    {
                        C1 = "X";
                        playerOneTurn = false;
                    }
                }


                else if (playerOneResponse == "a2")
                {
                    if (A2 != "_")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This spot is already taken. Please choose a different spot.");
                        Console.ResetColor();
                    }
                    else
                    {
                        A2 = "X";
                        playerOneTurn = false;
                    }
                }


                else if (playerOneResponse == "b2")
                {
                    if (B2 != "_")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This spot is already taken. Please choose a different spot.");
                        Console.ResetColor();
                    }
                    else
                    {
                        B2 = "X";
                        playerOneTurn = false;
                    }
                }

                else if (playerOneResponse == "c2")
                {
                    if (C2 != "_")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This spot is already taken. Please choose a different spot.");
                        Console.ResetColor();
                    }
                    else
                    {
                        C2 = "X";
                        playerOneTurn = false;
                    }
                }

                else if (playerOneResponse == "a3")
                {
                    if (A3 != " ")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This spot is already taken. Please choose a different spot.");
                        Console.ResetColor();
                    }
                    else
                    {
                        A3 = "X";
                        playerOneTurn = false;
                    }
                }

                else if (playerOneResponse == "b3")
                {
                    if (B3 != " ")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This spot is already taken. Please choose a different spot.");
                        Console.ResetColor();
                    }
                    else
                    {
                        B3 = "X";
                        playerOneTurn = false;
                    }
                }

                else if (playerOneResponse == "c3")
                {
                    if (C3 != " ")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This spot is already taken. Please choose a different spot.");
                        Console.ResetColor();
                    }
                    else
                    {
                        C3 = "X";
                        playerOneTurn = false;
                    }
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid response. Please try again, " + playerOne);
                    Console.ResetColor();
                }

            }
        }

        if ((A1 == "X" && B1 == "X" && C1 == "X") || (A1 == "X" && A2 == "X" && A3 == "X") || (A1 == "X" && B2 == "X" && C3 == "X") ||
            (A2 == "X" && B2 == "X" && C2 == "X") || (B1 == "X" && B2 == "X" && B3 == "X") || (A3 == "X" && B2 == "X" && C1 == "X") ||
            (A3 == "X" && B3 == "X" && C3 == "X") || (C1 == "X" && C2 == "X" && C3 == "X"))
        {
            Console.WriteLine("  A B C \n1 " + A1 + "|" + B1 + "|" + C1 + "\n2 " + A2 + "|" + B2 + "|" + C2 + "\n3 " + A3 + "|" + B3 + "|" + C3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(playerOne + " wins!");
            Console.ResetColor();
            gameConclusion = true;
            Console.WriteLine("Would you like to play again? ('Y' or 'N')");
            string response = Console.ReadLine();
            if (response == "n" || response == "N")
            {
                keepPlaying = false;
            }
        }

        else if (A1 != "_" && B1 != "_" && C1 != "_" && A2 != "_" && B2 != "_" && C2 != "_" && A3 != " " && B3 != " " && C3 != " ")
        {
            Console.WriteLine("  A B C \n1 " + A1 + "|" + B1 + "|" + C1 + "\n2 " + A2 + "|" + B2 + "|" + C2 + "\n3 " + A3 + "|" + B3 + "|" + C3);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("It's a tie!");
            Console.ResetColor();
            gameConclusion = true;
            Console.WriteLine("Would you like to play again? ('Y' or 'N')");
            string response = Console.ReadLine();
            if (response == "n" || response == "N")
            {
                keepPlaying = false;
            }
        }

        else
        {
            while (playerOneTurn == false)
            {
                Console.WriteLine("  A B C \n1 " + A1 + "|" + B1 + "|" + C1 + "\n2 " + A2 + "|" + B2 + "|" + C2 + "\n3 " + A3 + "|" + B3 + "|" + C3); //Draws the game board
                Console.WriteLine(playerTwo + "'s turn. Enter your respose like your playing Bingo! Example: a1");
                string playerTwoResponse = Console.ReadLine();

                if (playerTwoResponse == "a1")
                {
                    if (A1 != "_")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This spot is already taken. Please choose a different spot.");
                        Console.ResetColor();
                    }
                    else
                    {
                        A1 = "O";
                        playerOneTurn = true;
                    }
                }

                else if (playerTwoResponse == "b1")
                {
                    if (B1 != "_")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This spot is already taken. Please choose a different spot.");
                        Console.ResetColor();
                    }
                    else
                    {
                        B1 = "O";
                        playerOneTurn = true;
                    }
                }

                else if (playerTwoResponse == "c1")
                {
                    if (C1 != "_")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This spot is already taken. Please choose a different spot.");
                        Console.ResetColor();
                    }
                    else
                    {
                        C1 = "O";
                        playerOneTurn = true;
                    }
                }

                else if (playerTwoResponse == "a2")
                {
                    if (A2 != "_")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This spot is already taken. Please choose a different spot.");
                        Console.ResetColor();
                    }
                    else
                    {
                        A2 = "O";
                        playerOneTurn = true;
                    }
                }

                else if (playerTwoResponse == "b2")
                {
                    if (B2 != "_")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This spot is already taken. Please choose a different spot.");
                        Console.ResetColor();
                    }
                    else
                    {
                        B2 = "O";
                        playerOneTurn = true;
                    }
                }

                else if (playerTwoResponse == "c2")
                {
                    if (C2 != "_")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This spot is already taken. Please choose a different spot.");
                        Console.ResetColor();
                    }
                    else
                    {
                        C2 = "O";
                        playerOneTurn = true;
                    }
                }

                else if (playerTwoResponse == "a3")
                {
                    if (A3 != " ")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This spot is already taken. Please choose a different spot.");
                        Console.ResetColor();
                    }
                    else
                    {
                        A3 = "O";
                        playerOneTurn = true;
                    }
                }

                else if (playerTwoResponse == "b3")
                {
                    if (B3 != " ")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This spot is already taken. Please choose a different spot.");
                        Console.ResetColor();
                    }
                    else
                    {
                        B3 = "O";
                        playerOneTurn = true;
                    }
                }

                else if (playerTwoResponse == "c3")
                {
                    if (C3 != " ")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This spot is already taken. Please choose a different spot.");
                        Console.ResetColor();
                    }
                    else
                    {
                        C3 = "O";
                        playerOneTurn = true;
                    }
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid response. Please try again, " + playerTwo);
                    Console.ResetColor();
                }

            }
        }
    }
}