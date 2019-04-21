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
        var direction = random.Next(1, 10) % 2 == 0 
            ? Vector2.left
            : Vector2.right;
        ballRigidbody.AddForce(direction * speed);
    }
}
