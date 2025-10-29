using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Method that loads game
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    //Method that loads settings screen
    public void GameSettings()
    {
        SceneManager.LoadScene(3);
    }
    // Method that loads Controls screen
    public void GameControls()
    {
        SceneManager.LoadScene(4);
    }
    //Method that quits game
    public void QuitGame()
    {
        Application.Quit();
    }
}

// https://www.youtube.com/watch?v=DX7HyN7oJjE&t=246s - reference to be added