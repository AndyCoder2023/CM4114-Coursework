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
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void AddToHealth(int val)
    {
        healthPlayer = val;
    }

    public void AddToKills(int val)
    {
        killsPlayer = val;
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


