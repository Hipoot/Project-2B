using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPSpawn : MonoBehaviour
{
    public GameObject StarPiece;
    public float difficulty = 0;
    public bool MovementEnabled = false;
    private bool GameStarted = false;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", .3f, 1.0f - difficulty);
    }

    // Update is called once per frame
    void Update()
    {
        if(difficulty >= 2.5f)
        {
            // do nothing
        }
        else
        {
            difficulty += 0.0001f;
        }

        if (Input.GetMouseButtonDown(0) && GameStarted == false)
        {
            GameStarted = true;
            MovementEnabled = true;
        }
    }

    void Spawn()
    {

        if (MovementEnabled == true)
        {
            Instantiate(StarPiece);
        }
    }
}
