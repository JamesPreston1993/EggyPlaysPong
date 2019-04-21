using UnityEngine;
using Random = System.Random;

public class BallMovement : MonoBehaviour
{
    public float speed;

    private Rigidbody2D ballRigidbody;
    private Random random;

    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody2D>();
        random = new Random();

        var direction = RandomHorizontalDirection() + RandomVerticalDirection();
        ballRigidbody.AddForce(direction * speed);
    }

    Vector2 RandomHorizontalDirection()
    {
        return random.Next(1, 10) % 2 == 0
            ? Vector2.left
            : Vector2.right;
    }

    Vector2 RandomVerticalDirection()
    {
        return random.Next(1, 10) % 2 == 0
            ? Vector2.up
            : Vector2.down;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player One Goal")
        {
            GameManager.Instance.PlayerTwoScore++;
        }

        if (collision.gameObject.name == "Player Two Goal")
        {
            GameManager.Instance.PlayerOneScore++;
        }
    }
}
