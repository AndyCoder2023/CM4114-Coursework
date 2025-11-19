using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Get the PlayerControl component from the object that entered the trigger
        PlayerControl controller = other.GetComponent<PlayerControl>();

        if (controller != null)
        {
            // Call the new Heal method on the PlayerControl script
            controller.Heal(20);

            Destroy(gameObject); // Remove the collectible from the scene
            Debug.Log("Picked up 20 health!");
        }
    }
}