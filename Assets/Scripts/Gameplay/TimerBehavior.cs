using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Controls and displays the game's timer
/// </summary>
public class TimerBehavior : MonoBehaviour
{
    [SerializeField]
    private Text _timeText;
    [SerializeField]
    private float _totalTime;
    private bool _timerIsRunning;

    private void Start()
    {
        _timerIsRunning = true;
    }

    private void Update()
    {
        if (_timerIsRunning)
        {
            if (_totalTime > 0)
            {
                _totalTime -= Time.deltaTime;
                DisplayTime(_totalTime);
            }
            else
            {
                _totalTime = 0;
                _timerIsRunning = false;
                SceneManager.LoadScene("GameOverScreen");
            }
        }
        
    }

    /// <summary>
    /// Converts the display time to minutes, seconds format
    /// </summary>
    public void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        string clock = string.Format("{0:00}:{1:00}", minutes, seconds);
        _timeText.text = "Time: " + clock;

    }
}
