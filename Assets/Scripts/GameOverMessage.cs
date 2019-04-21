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
            winner.SetText(string.Format("{0} wins!", winnerName));
        };
    }
}
