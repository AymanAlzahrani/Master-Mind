// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

public abstract class Program

{
    static void Main(string[] args)
    {

        GameManger gameManger = new GameManger();





        Console.WriteLine("Will you find the secret code?");
        Console.WriteLine("Please enter a valid guess");


        gameManger.generateor();


        if (args.Length != 0)
        {
            gameManger.isSetted = true;
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "-c" && i + 1 < args.Length && gameManger.validationMethod(args[1]))
                {

                    gameManger.correctAnswer = args[i + 1];
                    gameManger.isSetted = false;

                    break;
                }
                else if (args[i] == "-t" && i + 1 < args.Length)
                {
                    try
                    {
                        gameManger.roundsNum = Convert.ToInt32(args[i + 1]);
                        break;
                    }
                    catch {Console.WriteLine("Wrong attempts input"); }
                }
                gameManger.isSetted = false;
                

            }
        }

        // to cheat and see the code don't worry I will not tell anyone
        // Console.WriteLine(gameManger.correctAnswer);



        gameManger.gameStart();






    }



}