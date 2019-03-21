using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMusicAdjuster : MonoBehaviour
{
    public Slider music;
    private float sliderValue;
    // Finds the audio source game objects in other scenes to be adjusted
    private GameObject[] gMusic;
    private AudioSource game;
    // Start is called before the first frame update
    void Start()
    {
        music.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        gMusic = GameObject.FindGameObjectsWithTag("Music");
        
    }
    // Listener for slider changes.
    void ValueChangeCheck()
    {
        for (int i = 0; i < gMusic.Length; i++)
        {
            gMusic[i].GetComponent<AudioSource>().volume = music.value;
        }
    }

    void OnGUI()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
