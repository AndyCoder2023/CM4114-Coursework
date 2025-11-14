using UnityEngine;

public class GameStateManager : MonoBehaviour
{

    public static GameStateManager instance = null;
    private int counter;
    public int health;

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

    public void AddToCounter(int val)
    {
        counter += val;
    }

    public int GetCounter()
    {
        return counter;
    }

    public int getHealth()
    {
        return health;
    }
  }


