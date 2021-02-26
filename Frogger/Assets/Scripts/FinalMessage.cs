using UnityEngine;
using UnityEngine.UI;

public class FinalMessage : MonoBehaviour
{
    public Text displayFinalMessage;
    void Start()
    {
        displayFinalMessage.text = DataManager.playerName + " scored " + DataManager.playerScore + " points with a + " + DataManager.gameSpeed + " speed bonus while using " + DataManager.playerLivesAtStart + " lives.";
    }

}
