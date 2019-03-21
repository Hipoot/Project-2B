using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonMove : MonoBehaviour
{
    public Vector3 Direction = new Vector3(1,0,0);
    public float Speed = 200;
    public bool MovementEnabled = false;
    private bool GameStarted = false;
    //public float Rvalue = Random.value;
    // Start is called before the first frame update
    void Start()
    {
        // 2.5 seconds on startup, then one second infinitely after for flipping direction (chance)
        InvokeRepeating("FlipChance", 2.5f, 1.0f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameStarted == false)
        {
            GameStarted = true;
            MovementEnabled = true;
        }
        if (MovementEnabled == true)
        {
            transform.position += Direction * Speed * Time.deltaTime;
            // If moon gets too close to edge, turn around
            if (transform.position.x + (Direction.x * Time.deltaTime * Speed) >= 7.5f)
            {
                Direction *= -1;
            }
            if (transform.position.x + (Direction.x * Time.deltaTime * Speed) <= -7.5f)
            {
                Direction *= -1;
            }
        }
        
    }

    void FlipChance()
    {
        float Chance = Random.value;
        if(Chance <= .45f)
        {
            Direction *= -1;
        }
    }
}
