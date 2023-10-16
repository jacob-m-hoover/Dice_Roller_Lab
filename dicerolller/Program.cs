// See https://aka.ms/new-console-template for more information


using System.Runtime.CompilerServices;
string userInputYN = "Y";
Console.WriteLine("Let's create two dice, then we can roll them :)");
int firstNumberOfSides = NumberOfSides("Enter the number of sides for the first die");
int secondnumberOfSides = NumberOfSides("Enter the number of sides for the second die");
do
{
    if (firstNumberOfSides == 6 && secondnumberOfSides == 6)
    {
        int firstDieResult = RandomNumberFromDice(firstNumberOfSides);
        int secondDieResult = RandomNumberFromDice(secondnumberOfSides);
        Console.WriteLine($"The first die rolled a: {firstDieResult} and the second die rolled a: {secondDieResult}");
        Console.WriteLine(SixSidedCombinations(firstDieResult, secondDieResult));
        Console.WriteLine(SixSideWinOrCraps(firstDieResult, secondDieResult));
    }
    else
    {
        Console.WriteLine($"The first die rolled a:  {RandomNumberFromDice(firstNumberOfSides)} and the second die rolled a: {RandomNumberFromDice(secondnumberOfSides)}");
    }
    Console.WriteLine("Would you like to roll these dice again? Y/N");
    userInputYN = Console.ReadLine().ToUpper();
}
while (userInputYN == "Y");


static int RandomNumberFromDice(int userInputNumber)
{
    Random r = new Random();
    int randomNumber = r.Next(1, userInputNumber);
    return randomNumber;
}

static int NumberOfSides(string userPrompt)
{
    while (true)
    {
        Console.WriteLine(userPrompt);
        string userInput = Console.ReadLine();
        if (int.TryParse(userInput, out int result) && result > 0)
        {
            return result;
        }

        Console.WriteLine("Not a valid input, try again");
    }

}

static string SixSidedCombinations(int firstDie, int secondDie)
{
    string comboResult = "";
    if (firstDie + secondDie == 2)
    {
        comboResult = "Snake eys!";
    }
    if (firstDie + secondDie == 3)
    {
        comboResult = "Ace Deuce!";
    }
    if (firstDie + secondDie == 12)
    {
        comboResult = "Box Cars!";
    }
    return comboResult;
}

static string SixSideWinOrCraps(int firstDie, int secondDie)
{
    string winCrapsResult ="";
    bool craps = SixSidedCombinations(firstDie, secondDie) != "";
    if (firstDie + secondDie == 7 || firstDie + secondDie == 12)
    {
        winCrapsResult = "You Win!";
    }
    if (craps)
    {
        winCrapsResult = "Craps!";
    }

    return winCrapsResult;

}
