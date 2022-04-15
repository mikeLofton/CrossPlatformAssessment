using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Manages the score display
/// </summary>
public class ScoreBehavior : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;
    public static int Score = 0;

    private void Start()
    {
        if (SceneManager.GetSceneByName("SampleScene").isLoaded) //At the start of the SampleScene set the score to zero
            Score = 0;
    }

    private void Update()
    {
        if (Score < 0) //If the score is less than zero than set it to zero
            Score = 0;

        _scoreText.text = $"Score: {Score}"; //Display text
    }
}
