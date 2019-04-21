using TMPro;
using UnityEngine;

public class GameOverMessage : MonoBehaviour
{
    public TextMeshProUGUI winner;

    void Start ()
    {
        GameManager.Instance.GameOver = winnerName =>
        {
            GameManager.Instance.IsGameOver = true;

            var message = string.Format("{0} wins!\n\nPress Space to\nPlay Again", winnerName);
            winner.SetText(message);
        };
    }
}
