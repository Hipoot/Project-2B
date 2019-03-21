using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayInfo : MonoBehaviour
{
    public int Score = 0;
    public int Lives = 5;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (Lives == 0)
        {
            Lives = 5;
            SceneManager.LoadScene("EndScreen");
        }
    }
}