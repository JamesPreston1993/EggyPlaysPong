using TMPro;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    public TextMeshProUGUI playerOneScore;
    public TextMeshProUGUI playerTwoScore;

    void Update ()
    {
        playerOneScore.SetText(GameManager.Instance.PlayerOneScore.ToString());
        playerTwoScore.SetText(GameManager.Instance.PlayerTwoScore.ToString());
    }
}
