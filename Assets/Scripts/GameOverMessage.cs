using TMPro;
using UnityEngine;

public class GameOverMessage : MonoBehaviour
{
    public TextMeshProUGUI winner;
    public TextMeshProUGUI restart;

    void Start ()
    {
        GameManager.Instance.GameOver = winnerName =>
        {
            GameManager.Instance.IsGameOver = true;

            var message = string.Format("{0} wins!", winnerName);
            winner.SetText(message);

            restart.SetText("Press Space to Play Again");
        };
    }
}
