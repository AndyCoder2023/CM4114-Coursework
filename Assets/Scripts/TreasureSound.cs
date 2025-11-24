using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureSound : MonoBehaviour
{

    // Use this for initialization
    void OnTriggerEnter(Collider ent)
    {
        this.GetComponent<AudioSource>().Play(); // Plays sound when player enters trigger zone
    }

    void OnTriggerExit(Collider ext)
    {
        this.GetComponent<AudioSource>().Stop();
    }

}
