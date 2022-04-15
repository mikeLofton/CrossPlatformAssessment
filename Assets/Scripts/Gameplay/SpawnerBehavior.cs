using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Spawns the game characters randomly
/// </summary>
public class SpawnerBehavior : MonoBehaviour
{
    [SerializeField]
    private CharacterMovementBehavior _redTarget;
    [SerializeField]
    private CharacterMovementBehavior _goldTarget;
    [SerializeField]
    private CharacterMovementBehavior _buddy1;
    [SerializeField]
    private CharacterMovementBehavior _buddy2;

    private CharacterMovementBehavior[] _characters;

    [SerializeField]
    private float _cooldown = 3.0f; //Seconds to wait until next spawn
    private float _timer = 0.0f;

    private void Start()
    {
        _characters = new CharacterMovementBehavior[4]; //Add characters to the character array
        _characters[0] = _redTarget;
        _characters[1] = _goldTarget;
        _characters[2] = _buddy1;
        _characters[3] = _buddy2;
    }

    // Update is called once per frame
    void Update()
    {
        float characterNum = Random.Range(0, 4);

       if (_timer >= _cooldown)
       {
            CharacterMovementBehavior spawnedCharacter = Instantiate(_characters[(int)characterNum], transform.position, _characters[(int)characterNum].transform.rotation);
            _timer = 0.0f;

            if (transform.position.x < 0)
            {
                spawnedCharacter.MovesRight = true;
                spawnedCharacter.MovesLeft = false;
            }
            else if (transform.position.x > 0)
            {
                spawnedCharacter.MovesRight = false;
                spawnedCharacter.MovesLeft = true;
            }
                

       }
        _timer += Time.deltaTime;
    }
}
