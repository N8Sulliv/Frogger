using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D birdrb;
    public float speed = 1f;
    public float minSpeed = 6f;
    public float maxSpeed = 9f;

    float countdown = 3f;
    public GameObject bird;

    private void Start()
    {
        speed = Random.Range(minSpeed + DataManager.gameSpeed, maxSpeed + DataManager.gameSpeed);
     
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        birdrb.MovePosition(birdrb.position + forward * Time.fixedDeltaTime * speed);

        if (countdown <= 0f)
        {
            Object.Destroy(bird);
        }
        else
        {
            countdown -= Time.deltaTime;
        }
    }
}
