using UnityEngine;

public class Border : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            player.transform.position = new Vector2(0, -4);
        }
    }
}
