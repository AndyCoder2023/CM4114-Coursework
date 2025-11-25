using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FinalSceneResults : MonoBehaviour
{
    public TMP_Text killText;
    public TMP_Text treasureText;

    void Update()
    {

        // 1. Update KILLS and TREASURE UI by reading from the PERSISTENT GameStateManager
        if (GameStateManager.instance != null)
        {
            killText.text = GameStateManager.instance.GetKills().ToString();
            treasureText.text = GameStateManager.instance.GetTreasure().ToString();
        }
    }
}