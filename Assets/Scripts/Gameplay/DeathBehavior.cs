using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBehavior : MonoBehaviour
{
    private float _currentLifeTime;
    private float _lifetime = 10.0f;

    private void OnMouseDown()
    {
        if (gameObject.tag == "RedTarget")
            ScoreBehavior.Score += 100;
        else if (gameObject.tag == "GoldTarget")
            ScoreBehavior.Score += 500;
        else if (gameObject.tag == "FirstBuddy")
            ScoreBehavior.Score -= 100;
        else if (gameObject.tag == "SecondBuddy")
            ScoreBehavior.Score -= 500;

        Destroy(gameObject);
    }

    private void Update()
    {
        _currentLifeTime += Time.deltaTime;

        if (_currentLifeTime >= _lifetime)
            Destroy(gameObject);
    }
}
