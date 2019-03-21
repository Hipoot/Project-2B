using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPTorque : MonoBehaviour
{
    private GameObject moon;
    // Awake is called before starting!
    void Awake()
    {
        moon = GameObject.Find("MO0n");
        transform.position = moon.transform.position;
        gameObject.GetComponent<Rigidbody2D>().AddTorque(Random.Range(-5f, 5f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
