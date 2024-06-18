using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameOverPanel; // Assign this in the inspector

    void Start()
    {
        gameOverPanel.SetActive(false); // Hide on start
    }

    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true); // Show the game over screen
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("main"); // Reload current scene
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("menu"); // Make sure the scene name matches your menu scene
    }
}
