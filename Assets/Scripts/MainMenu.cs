using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Method thats loads main menu
    public void MainMenuScene()
    {
        SceneManager.LoadSceneAsync(0);
    }

    //Method that loads game
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    //Method that loads settings screen
    public void GameSettings()
    {
        SceneManager.LoadSceneAsync(3);
    }

    // Method that loads Controls screen
    public void GameControls()
    {
        SceneManager.LoadSceneAsync(4);
    }

    //Method that quits game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is now closed.");
    }
}