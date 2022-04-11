using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBehavior : MonoBehaviour
{
    private float _currentLifeTime;
    private float _lifetime = 10.0f;

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        _currentLifeTime += Time.deltaTime;

        if (_currentLifeTime >= _lifetime)
            Destroy(gameObject);
    }
}
