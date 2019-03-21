using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScores : MonoBehaviour
{
    public int score;
    List<int> highscores = new List<int>();
    public string display;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();
        score = GameObject.Find("PlayerInfo").GetComponent<PlayInfo>().Score;
        for (int i = 1; i < 11; i++)
        {
            if (!PlayerPrefs.HasKey("HighScore " + (i).ToString() + ":"))
            {
                highscores.Add(0);
                PlayerPrefs.SetInt("HighScore " + (i).ToString()+":", 0);
            }
        }
        if (score >= PlayerPrefs.GetInt("HighScore 1:"))
        {
            highscores.Add(score);
            highscores.Sort();
            highscores.Reverse();

            for (int i = 1; i < 11; i++)
            {
                PlayerPrefs.SetInt("HighScore " + (i).ToString() + ":", highscores[i]);
                display = display + "HighScore " + (i).ToString() + ": " + PlayerPrefs.GetInt("HighScore " + (i).ToString()+":") + "\r\n";
            }
            gameObject.GetComponent<Text>().text = (display);
        }

    }

}