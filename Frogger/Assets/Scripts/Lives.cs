using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public static int lives = DataManager.playerLives;
    public Text showLives;
    void Start()
    {
        showLives.text = "Lives: " + lives.ToString();
    }

    
}
