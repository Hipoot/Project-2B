using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplayer : MonoBehaviour
{
    public string Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = GameObject.Find("PlayerInfo").GetComponent<PlayInfo>().Score.ToString();
        gameObject.GetComponent<Text>().text = Score;
    }

    // Update is called once per frame
    void Update()
    {

    }
}