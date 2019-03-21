using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySE : MonoBehaviour
{
    public GameObject Options;
    public AudioSource SE;
    // Start is called before the first frame update
    void Start()
    {
        //Fetch the AudioSource from the GameObject
        SE = GetComponent<AudioSource>();
        //Ensure the toggle is set to true for the music to play at start-up
        SE.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
