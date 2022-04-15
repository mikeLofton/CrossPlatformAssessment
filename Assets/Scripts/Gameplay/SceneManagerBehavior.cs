using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// Manages the transition of scenes and closing the game
/// </summary>
public class SceneManagerBehavior : MonoBehaviour
{   
    /// <summary>
    /// Changes the scene to one with the given name
    /// </summary>
    /// <param name="sceneName">The scene you want to change to</param>
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    /// <summary>
    /// Closes the application
    /// </summary>
    public void CloseGame()
    {
        Application.Quit();
    }
}
