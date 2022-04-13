using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreBehavior : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;
    public static int Score = 0;

    private void Start()
    {
        if (SceneManager.GetSceneByName("SampleScene").isLoaded)
            Score = 0;
    }

    private void Update()
    {
        if (Score < 0)
            Score = 0;

        _scoreText.text = $"Score: {Score}";
    }
}
