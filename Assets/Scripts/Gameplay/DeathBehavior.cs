using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBehavior : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
