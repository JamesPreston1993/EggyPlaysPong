using System;

public class GameManager
{
    public int PlayerOneScore { get; set; }

    public int PlayerTwoScore { get; set; }

    private GameManager()
    {
        PlayerOneScore = 0;
        PlayerTwoScore = 0;
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
}
