using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{
    public KeyCode UpKey;
    public KeyCode DownKey;

    private float speed = 6.0f;

    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        var movement = new Vector3();
        if (Input.GetKey(UpKey))
        {
            movement += Vector3.up;
        }

        if (Input.GetKey(DownKey))
        {
            movement += Vector3.down;
        }

        SetAnimationState(movement.y != 0.0f);

        transform.position += movement * speed * Time.deltaTime;
    }

    private void SetAnimationState(bool isWalking)
    {
        if (animator.GetBool("IsWalking") != isWalking)
        {
            animator.SetBool("IsWalking", isWalking);
        }
    }
}
