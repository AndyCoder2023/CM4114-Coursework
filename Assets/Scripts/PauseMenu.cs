using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject container;

    void Update()
    { // Pauses game when user clicks escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            container.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ResumeButton()
    {
    // Unpauses game
        container.SetActive(false);
        Time.timeScale = 1;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadSceneAsync(0);
    }

    //Method that quits game
    public void QuitGame()
    {
        Application.Quit();
    }
}
