using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // If user touches game object then moves onto next level2
        if (other.tag == "LevelExit")
        {
            SceneManager.LoadScene(1);
        }

    }
}

// https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadScene.html
