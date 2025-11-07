using UnityEngine;

public class GameStateManager : MonoBehaviour
{

    public static GameStateManager instance = null;
    private int _counter;

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
        _counter += val;
    }

    public int GetCounter()
    {
        return _counter;
    }


}


