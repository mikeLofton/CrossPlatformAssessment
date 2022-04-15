using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class that handles the destruction and points of game characters
/// </summary>
public class DeathBehavior : MonoBehaviour
{
    private float _currentLifeTime; //How many seconds the attached character has been in the scene
    private float _lifetime = 10.0f; //How many seconds the attached character can exist in a scene

    private void OnMouseDown()
    {
        //Increase or decrease points
        if (gameObject.tag == "RedTarget")
            ScoreBehavior.Score += 100;
        else if (gameObject.tag == "GoldTarget")
            ScoreBehavior.Score += 500;
        else if (gameObject.tag == "FirstBuddy")
            ScoreBehavior.Score -= 100;
        else if (gameObject.tag == "SecondBuddy")
            ScoreBehavior.Score -= 500;

        Destroy(gameObject); //Destroy the object
    }

    private void Update()
    {
        _currentLifeTime += Time.deltaTime;

        if (_currentLifeTime >= _lifetime) //If the current lifetime is greater than or equal to the lifetime destroy the object
            Destroy(gameObject);
    }
}
