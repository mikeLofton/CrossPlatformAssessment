using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public bool MovesLeft
    {
        get { return _movesLeft; }
        set { _movesLeft = value; }
    }

    public bool MovesRight
    {
        get { return _movesRight; }
        set { _movesRight = value; }
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
