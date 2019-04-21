using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    public Transform playerOne;
    public Transform playerTwo;
    public GameObject ballPrefab;

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
                Instantiate(ballPrefab);
            }
        };
    }

    void Update()
    {
        if (GameManager.Instance.IsGameOver)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
