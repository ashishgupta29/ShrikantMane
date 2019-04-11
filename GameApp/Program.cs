using System;
using ServiceLayer.Players.Interface;
using ServiceLayer.Result;
using ServiceLayer.CommonUtility;
using ServiceLayer.Validation;

namespace GameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo iEscapeKeyValue;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter the number 1/2 only for Player type,  1: Human Players 2: Computer Player ");

                int intPlayerType = isValidNumber(Console.ReadLine());

                GameResult reslt = new GameResult();

                Console.WriteLine("Please choose item ROCK, SCISSORS or PAPER?");
                Console.WriteLine("It take 3 rounds to complete the match, you have to enter items thrice! \n");

                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine("Round : " + i);

                    IValidation valid = new Validation();

                    if (intPlayerType == 1)
                    {
                        Console.WriteLine("Please enter Item by First Player");
                        string p1ChoosedItem = Console.ReadLine();
                        p1ChoosedItem = isValidItem(p1ChoosedItem);

                        Console.WriteLine("Please enter Item by Second Player");
                        string p2ChoosedItem = Console.ReadLine();
                        p2ChoosedItem = isValidItem(p2ChoosedItem);

                        var result = reslt.getResult(HelperClass.getSelectedItemByPlayer(p1ChoosedItem), HelperClass.getSelectedItemByPlayer(p2ChoosedItem));

                        Console.WriteLine("Result of round " + i + ":- " + result + "\n");
                    }
                    else
                    {
                        Console.WriteLine("Please enter Item by First Player");
                        string p1ChoosedItem = Console.ReadLine();
                        p1ChoosedItem = isValidItem(p1ChoosedItem);

                        IComputerPlayer comPlayer = new ComputerPlayer();
                        var comChoosedItem = comPlayer.getComputerChoosedItem();
                        Console.WriteLine("Computer Choosed Item:- " + comChoosedItem);

                        var result = reslt.getResult(HelperClass.getSelectedItemByPlayer(p1ChoosedItem), comChoosedItem);

                        Console.WriteLine("Result of round " + i + ":- " + result + "\n");
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("Game Final Result :- " + reslt.getFinalResult());

                Console.WriteLine("");
                Console.WriteLine("Press the Escape (Esc) key to quit:");
                iEscapeKeyValue = Console.ReadKey();
                Console.WriteLine("");

            } while (iEscapeKeyValue.Key != ConsoleKey.Escape);
        }

        private static string isValidItem(string item)
        {
            IValidation valid = new Validation();
            bool isValidEnterValue = false;

            do
            {
                if (valid.isValidChoosedItem(item))
                    isValidEnterValue = true;
                else
                {
                    isValidEnterValue = false;
                    Console.WriteLine(Constant.ENTER_WRONG_ITEM);
                    item = Console.ReadLine();
                }

            } while (!isValidEnterValue);

            return item;
        }

        private static int isValidNumber(string inputNumber)
        {
            int value;
            bool isValidEnterValue = false;

            do
            {
                if ((int.TryParse(inputNumber, out value)) && (Convert.ToInt16(inputNumber) == 1 || Convert.ToInt16(inputNumber) == 2))
                    isValidEnterValue = true;
                else
                {
                    isValidEnterValue = false;
                    Console.WriteLine(Constant.ENTER_WRONG_NUMBER);
                    inputNumber = Console.ReadLine();
                }                    

            } while (!isValidEnterValue);


            return Convert.ToInt32(inputNumber);
        }

    }
}
