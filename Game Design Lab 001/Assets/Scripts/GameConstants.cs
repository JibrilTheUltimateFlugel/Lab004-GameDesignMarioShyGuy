using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameConstants", menuName = "ScriptableObjects/GameConstants", order = 1)] // the header allows us to create instances of this class in the Project
public class GameConstants : ScriptableObject // we let it inherit ScriptableObject
{
    // for Scoring system
    int currentScore; //player current score
    int currentPlayerHealth; //marios current HP

    // for Reset values
    Vector3 gombaSpawnPointStart = new Vector3(2.5f, -0.45f, 0); // hardcoded location
                                                                 // .. other reset values 

    // for Consume.cs
    public int consumeTimeStep = 10;
    public int consumeLargestScale = 4;

    // for Break.cs
    public int breakTimeStep = 30;
    public int breakDebrisTorque = 10;
    public int breakDebrisForce = 10;

    // for SpawnDebris.cs
    public int spawnNumberOfDebris = 10;

    // for Rotator.cs
    public int rotatorRotateSpeed = 6;

    // for testing
    public int testValue;

    // for Enemy Controller
    public float maxOffset = 5.0f; // Max offset of patrolling to the left and the right
    public float enemyPatroltime = 5.0f; //enemy patrol time
    public float groundSurface = -1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
