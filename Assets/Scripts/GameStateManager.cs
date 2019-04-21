using UnityEngine;

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
    }

    void Start ()
    {
        GameManager.Instance.ResetGame = () =>
        {
            playerOne.position = initialPlayerOnePosition;
            playerTwo.position = initialPlayerTwoPosition;
            Instantiate(ballPrefab);
        };
    }
}
