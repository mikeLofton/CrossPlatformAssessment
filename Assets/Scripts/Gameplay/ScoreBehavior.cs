using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBehavior : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;
    private int _score = 0;

    public int Score
    {
        get { return _score; }
        set { _score = value; }
    }

    private void Update()
    {
        _scoreText.text = $"Score: {Score}";
    }
}
