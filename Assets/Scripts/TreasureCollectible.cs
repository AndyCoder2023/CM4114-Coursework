using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureCollectible : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Get the PlayerControl component from the object that entered the trigger
        PlayerControl controller = other.GetComponent<PlayerControl>();

        if (controller != null)
        {
            // *** CHANGE THIS LINE ***
            // Call the new Treasure method on the PlayerControl script
            controller.Treasure(1);

            Destroy(gameObject); // Remove the collectible from the scene
            Debug.Log("Picked up 1 treasure!");
        }
    }
}