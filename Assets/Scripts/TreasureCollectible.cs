using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureCollectible : MonoBehaviour
{
    // Inside TreasureCollectible.cs (or similar script)
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Directly update the GameStateManager's persistent data.
            if (GameStateManager.instance != null)
            {
                GameStateManager.instance.AddToTreasure(1);
                Debug.Log("Treasure collected! New Total: " + GameStateManager.instance.GetTreasure());
            }
            Destroy(gameObject);
        }
    }
}