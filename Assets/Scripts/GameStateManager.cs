using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    public Transform playerOne;
    public Transform playerTwo;
    public GameObject ballPrefab;
    public TextMeshProUGUI countdown;

    private Vector3 initialPlayerOnePosition;
    private Vector3 initialPlayerTwoPosition;

    void Awake()
    {
        initialPlayerOnePosition = playerOne.position;
        initialPlayerTwoPosition = playerTwo.position;
        GameManager.Instance.PlayerOneScore = 0;
        GameManager.Instance.PlayerTwoScore = 0;
    }

    void Start ()
    {
        GameManager.Instance.ResetGame = () =>
        {
            if (!GameManager.Instance.IsGameOver)
            {
                playerOne.position = initialPlayerOnePosition;
                playerTwo.position = initialPlayerTwoPosition;
                var ball = Instantiate(ballPrefab);
                StartCoroutine(CountdownAndStart(ball.GetComponent<BallMovement>()));
            }
        };
        GameManager.Instance.ResetGame();
    }

    void Update()
    {
        if (GameManager.Instance.IsGameOver)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                GameManager.Instance.IsGameOver = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    private IEnumerator CountdownAndStart(BallMovement ball)
    {
        countdown.SetText("3");
        yield return new WaitForSeconds(1f);

        countdown.SetText("2");
        yield return new WaitForSeconds(1f);

        countdown.SetText("1");
        yield return new WaitForSeconds(1f);

        countdown.SetText("");
        ball.StartMovement();
    }
}
