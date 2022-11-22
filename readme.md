**DY-73 Dice Roller** is a console application that presents multiple games of chance played against the computer.
The computer character is named DY-73 and presents as a lost AI from a distant world.

### NOTES
**PROGRAM START:** The program begins by calling the RunIntroScreen from the ConsoleMessages class.
RunIntroScreen sets the console text to green and displays various lines of text to introduce the narrative elements.
Thread.Sleep is called between lines of text to create a dynamic and surprising experience for the player.
The player is asked to press any key to continue.
After pressing a key, the Clear method is called on the console to introduce a new screen.
RunPlayerNameScreen is then called.
RunPlayerNameScreen continues the narrative and asks the player to input their name.
The player is once again asked to press enter to continue, the console is cleared again and then the SelectGame menu is displayed.

**SELECT GAME MENU:** SelectGame generates an arrow-key driven menu in the console.
The menu's functionality and design are established in the menu class.
SelectGame prompts the user to move the cursor with the up and down arrow keys on their keyboard to select a game to play and press enter.
The user's input executes cases in a switch that call methods that allow the user to play one of the games against the computer.

**HIGH DIE GAME:** Selecting High Die in the SelectGame menu calls the RunHighDieGame method from the HighDieGame class.
In High Die, the players take turns rolling a single die.
The player who rolls the highest number wins the game.
The Random class is instantiated and the Next method is called with a minValue of 1 and a maxValue of 7 in order to represent the die in the game.
The human player rolls first and then the computer rolls.
The DetermineHighDieWinner method is then called to declare the winner.
DetermineHighDieWinner uses an If-Else block to check the value of the playerRoll variable against the value of the cpuRoll variable.
The player who rolled the higher number is declared the winner or the game ends in a draw if both players rolled the same number.

**DOUBLES GAME:** Selecting Doubles in the SelectGame menu calls the RunDoublesGame method from the DoublesGame class.
In Doubles, the players each roll a pair of dice until they roll a matching pair.
The player who rolls a matching pair in the fewest turns wins the game.
The Random class is instantiated and the Next method is called with a minValue of 1 and a maxValue of 7 in order to represent the dice in the game.
The human player rolls first and remains in a while loop until they roll a matching pair of dice.
The increment (++) operator is applied to the value of the playerAttempts variable each time that the player rolls.
playerAttempts records and displays the total turns the player took before rolling a matching pair.
The computer player then rolls and remains in a while loop until it rolls a matching pair of dice.
The increment (++) operator is applied to the value of the cpuAttempts variable each time that the computer rolls.
cpuAttempts records and displays the total turns the computer took before rolling a matching pair.
Once both players have rolled a matching pair, the DetermineDoublesWinner method is called.
DetermineDoublesWinner uses an If-Else block to compare the values of the playerAttempts and computerAttempts variables.
The player with the lower number of attempts is declared the winner or the game ends in a draw if both players rolled the same number of attempts.

**BEST OF FIVE GAME:** Selecting Best of Five in the SelectGame menu calls the RunBestOfFiveGame method from the BestOfFiveGame class.
In Best of Five, take turns rolling a pair of dice.
Each player's dice are added together at the conclusion of their turn.
The player with the higher overall number is declared the winner of that round.
The winner of the round is assigned a point to their points total.
If the round ends in a draw, each player is subtracted one point.
The winner with the most points at the end of five rounds wins the game.
The Random class is instantiated and the Next method is called with a minValue of 1 and a maxValue of 7 in order to represent the dice in the game.
The human player rolls first and then the computer rolls.
The players remain in a for loop and continue to take turns rolling dice until the conclusion of five rounds.
The playerTotal variable adds each each of the player's dice together to determine the total value of their roll.
The cpuTotal variable adds each of the computer's dice together to determine the total value of its roll.
And If-Else block compares the values of the playerTotal and cpuTotal variables.
The player with the higher value is declared the winner of that round of play.
The winner is assigned a point by using the increment (++) operator on either the playerScore variable or the cpuScore variable.
A draw is declared if the value of the playerTotal and the cpuTotal variables is the same at the end of the round.
Each player is deducted one point by using the decrement (--) operator on both the playerScore and the cpuScore variables if the round ends in a draw.
The players exit the for loop at the conclusion of the fifth round and the DetermineBestOfFiveGameWinner method is called.
DetermineBestOfFiveGameWinner uses an If-Else block to compare the values of the playerScore and the cpuScore variables.
The player with the higher score is declared the winner or the game ends in a draw if both players have the same score.

**EXITING THE PROGRAM:** At the conclusion of each game, the ExitTheProgram method is called.
ExitTheProgram prompts the user to return to the SelectGame menu to continue playing or to terminate the program.
ExitTheProgram initializes a new instance of the menu class.
The user's input executes cases in a switch that return the player to the SelectGame menu or terminates the program with an exit method.

**DESIGN AND NARRATIVE ELEMENTS:** The application uses tabs and newlines in the WriteLine methods to for clarity and aesthetics.
Thread.Sleep is called throughout to enhance the computer character's dialogue and give it personality.
Console.Beep is used to provide the user with audible feedback each time that they make a selection.






