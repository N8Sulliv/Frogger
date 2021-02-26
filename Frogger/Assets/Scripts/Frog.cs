using UnityEngine;
using UnityEngine.SceneManagement;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bird")
        {
            DataManager.playerLives -= 1;
            Lives.lives -= 1;
            if (DataManager.playerLives <= 0)
            {
                SceneManager.LoadScene("ExitScreen");
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
