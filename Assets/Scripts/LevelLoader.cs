using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // If user touches game object then moves onto next level 2
        if (other.tag == "LevelExit")
        {
            SceneManager.LoadScene(2);
        }

        if (other.tag == "GameFinished")
        {
            SceneManager.LoadScene(5);
        }
    }

    // Need to add exit button functionality
  
}

// https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadScene.html
