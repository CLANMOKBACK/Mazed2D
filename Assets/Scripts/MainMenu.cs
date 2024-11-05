using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("_Scene_0");  // Ensure Level1 is the name of your first level scene
    }

    public void ShowCredits()
    {
        // You could either load a Credits scene or display credits in the menu
        SceneManager.LoadScene("Credits");
    }

    public void ReturnToMainMenu()
{
    SceneManager.LoadScene("MainMenu");
}
}