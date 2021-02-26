using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static string playerName;
    public static float gameSpeed;
    public static int playerLives;
    public static int playerLivesAtStart;
    public static int playerScore;

    public InputField playerNameInput;
    public Text displayPlayerName;
    public Dropdown selectLives;
    public Text displayLives;
    public Slider selectGameSpeed;
    public Text displayGameSpeed;
    public Text displayPlayerScore;
    public Text displayFinalMessage;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void Update()
    {
        playerScore = Score.score;
    }

    public void updateName()
    {
        playerName = playerNameInput.text;
    }

    public void showName()
    {
        displayPlayerName.text = "Player Name: " + playerName;
    }

    public void updateLives()
    {
        switch(selectLives.value)
        {
            case 0:
                playerLives = 1;
                playerLivesAtStart = 1;
                break;
            case 1:
                playerLives = 3;
                playerLivesAtStart = 3;
                break;
            case 2:
                playerLives = 5;
                playerLivesAtStart = 5;
                break;
            case 3:
                playerLives = 10;
                playerLivesAtStart = 10;
                break;
        }

        Debug.Log("Player Lives = " + playerLives);
    }

    public void showFinalMessage()
    {
        //Testing to see if selecting lives works
        
    }

    public void updateSpeed()
    {
        gameSpeed = selectGameSpeed.value;
    }

    public void showSpeed()
    {
        displayGameSpeed.text = "Bird Speed: " + gameSpeed.ToString();
    }
}
