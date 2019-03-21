using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    public GameObject playerInfo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Text>().text = "Score: " + playerInfo.GetComponent<PlayInfo>().Score.ToString() + "\r\nLives: " + playerInfo.GetComponent<PlayInfo>().Lives.ToString();
    }
}
