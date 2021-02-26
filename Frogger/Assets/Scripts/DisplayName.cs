using UnityEngine;
using UnityEngine.UI;

public class DisplayName : MonoBehaviour
{
    public Text playerName;
    void Start()
    {
        playerName.text = DataManager.playerName;
    }

}
