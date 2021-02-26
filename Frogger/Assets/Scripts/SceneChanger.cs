using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void Play()
    {
        if (DataManager.playerLives == 0)
        {
            DataManager.playerLives = 1;
            Lives.lives = 1;
            DataManager.gameSpeed = 1;
            DataManager.playerScore = 0;
            Score.score = 0;
        }
        SceneManager.LoadScene("Level1");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit");
    }

    public void Back()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex) - 1);
    }

    public void backToStart()
    {
        DataManager.playerLives = 1;
        Lives.lives = 1;
        DataManager.playerScore = 0;
        Score.score = 0;
        DataManager.gameSpeed = 1;
        SceneManager.LoadScene("StartScreen");
    }

    public void playAgain()
    {
        DataManager.playerLives = DataManager.playerLivesAtStart;
        Lives.lives = DataManager.playerLivesAtStart;
        DataManager.playerScore = 0;
        Score.score = 0;
        SceneManager.LoadScene("Level1");
    }
}
