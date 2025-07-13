public class GameManger : GameVariables
{


    // ----------------------------------
    public void generateor()
    {
        for (int i = 0; i < 4; i++)
        {
            String temp = rnd.Next(0, 8).ToString();
            while (correctCode.Contains(temp))
            {

                temp = rnd.Next(0, 8).ToString();
            }
            correctCode.Add(temp);
            correctAnswer += correctCode[i];
        }


    }
    //validate the user input using -c or 
    // ----------------------------------

    public bool validationMethod(String userInput)
    {

        while (true)
        {
            if (isSetted == false)
            {
                userAnswer = Console.ReadLine();
                userInput = userAnswer!;

            }


            if (userInput == null) { Environment.Exit(0); }

            else
            {
                bool isString = userInput!.All(char.IsDigit);

                if (!isString || userInput!.Length != 4 || userInput.Distinct().Count() != userInput.Length)
                {
                    Console.WriteLine("Wrong input!");

                    if (isSetted == false)
                    //instead of continue and while loop 
                    //it can be called again validationMethod(userInput)
                    //but I used loop because the risk of StackOverflowException for Large wrong inputs
                    { continue; }
                    else
                    {
                        return false;
                    }

                }
            }

            return true;
        }
    }



    // ----------------------------------

    public void checkerMethod(String user, String code)
    {

        for (int i = 0; i <= 3; i++)
        {
            if (user![i] == code[i])
            {
                correct++;
            }


            else if (code.Contains(user[i]))
            {
                missPlaced++;
            }
        }
    }


    public void gameStart()
    {
        for (int i = 0; i <= roundsNum; i++)
        {
            missPlaced = 0;
            correct = 0;
            Console.WriteLine("---");
            Console.WriteLine("Round " + i);


            validationMethod(userAnswer!);

            checkerMethod(userAnswer!, correctAnswer!);

            if (correct == 4)
            {
                Console.WriteLine("Congratz! You did it!");
                return;
            }
            Console.WriteLine("Well placed pieces: " + correct);
            Console.WriteLine("Misplaced pieces: " + missPlaced);

            if (i == roundsNum)
            {
                Console.WriteLine("You Lost");
            }



        }

    }

}