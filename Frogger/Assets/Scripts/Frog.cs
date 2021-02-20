using UnityEngine;

public class Frog : MonoBehaviour
{
    public Rigidbody2D frogrb;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            frogrb.MovePosition(frogrb.position + Vector2.right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            frogrb.MovePosition(frogrb.position + Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            frogrb.MovePosition(frogrb.position + Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            frogrb.MovePosition(frogrb.position + Vector2.down);
        }
    }
}
