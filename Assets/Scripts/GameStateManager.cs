using UnityEngine;

public class GameStateManager : MonoBehaviour
{

    public static GameStateManager instance = null;
    private int healthPlayer;
    public int killsPlayer;
    public int treasurePlayer;


    private void Start()
    {
        // Lock the cursor to the center of the game window
        Cursor.lockState = CursorLockMode.Locked;

        // Optionally, hide the cursor so it doesn't obstruct the view
        Cursor.visible = false;
    }

    private void Update()
    {
        // (e.g., for accessing a menu) by pressing a key like 'Escape'.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // If the cursor is locked, unlock it.
            if (Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None; // Set to 'None' to unlock
                Cursor.visible = true; // Show the cursor
            }
            // If the cursor is unlocked, lock it again (optional for a toggle)
            else if (Cursor.lockState == CursorLockMode.None)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }

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


