using System;

public class GameManager
{
    public string PlayerOneName { get; set; }

    private int playerOneScore;
    public int PlayerOneScore
    {
        get
        {
            return playerOneScore;
        }
        set
        {
            playerOneScore = value;
            if (playerOneScore >= ScoreLimit)
            {
                GameOver(PlayerOneName);
            }
        }
    }

    public string PlayerTwoName { get; set; }

    private int playerTwoScore;
    public int PlayerTwoScore
    {
        get
        {
            return playerTwoScore;
        }
        set
        {
            playerTwoScore = value;
            if (playerTwoScore >= ScoreLimit)
            {
                GameOver(PlayerTwoName);
            }
        }
    }

    public int ScoreLimit { get; set; }

    public bool IsGameOver { get; set; }

    private GameManager()
    {
        PlayerOneName = "Blue Eggy";
        PlayerTwoName = "Red Eggy";
        ScoreLimit = 1;
    }

    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
                instance = new GameManager();
            return instance;
        }
    }

    public Action ResetGame { get; set; }

    public Action<string> GameOver { get; set; }
}
