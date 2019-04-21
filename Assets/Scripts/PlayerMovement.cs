using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode UpKey;
    public KeyCode DownKey;

    private float speed = 6.0f;

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

        transform.position += movement * speed * Time.deltaTime;
    }

}
