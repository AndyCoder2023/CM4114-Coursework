using UnityEngine;

public class GameStateManager : MonoBehaviour
{

    public static GameStateManager instance = null;
    private int healthPlayer;
    public int killsPlayer;
    public int treasurePlayer;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            // Destroys any GameStateManager object that is loaded so that the same one is kept on each level
            Destroy(gameObject);
        }
    }


    // Methods that add 1 to counters for health, kills, and treasure
    public void AddToHealth(int val)
    {
        healthPlayer += val;
    }

    public void AddToKills(int val)
    {
        killsPlayer += val;
    }

    public void AddToTreasure(int val)
    {
        treasurePlayer += val;
    }

    public int getHealth()
    {
        return healthPlayer;
    }

    public int GetKills()
    {
        return killsPlayer;
    }

    public int GetTreasure()
    {
        return treasurePlayer;
    }
 
  }


