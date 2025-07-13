public abstract class GameVariables
{


    public Random rnd = new Random();

    public int roundsNum = 10;

    public int correct = 0;
    public int missPlaced = 0;
    public List<String> correctCode = [];
    public String? userAnswer;

    public String? correctAnswer;
    public bool isSetted = false;



}