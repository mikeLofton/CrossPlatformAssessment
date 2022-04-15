using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles the movement of game characters
/// </summary>
public class CharacterMovementBehavior : MovementBehavior
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private bool _movesLeft;
    [SerializeField]
    private bool _movesRight;

    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    /// <summary>
    /// True if the character can move left
    /// </summary>
    public bool MovesLeft
    {
        get { return _movesLeft; }
        set { _movesLeft = value; }
    }

    /// <summary>
    /// True if the character can move right
    /// </summary>
    public bool MovesRight
    {
        get { return _movesRight; }
        set { _movesRight = value; }
    }

    private void Start()
    {
        float speedNum = Random.Range(0.5f, 11.0f); //Randomizes movement speed at spawn
        Speed = speedNum;
    }

    public override void Update()
    {
        

        if (MovesLeft)
        {
            Vector3 direction = Vector3.left;
            Velocity = direction.normalized * Speed;
        }
        else if (MovesRight)
        {
            Vector3 direction = Vector3.right;
            Velocity = direction.normalized * Speed;
        }
        

        base.Update();
    }

}
