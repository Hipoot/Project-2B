using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StScene : MonoBehaviour
{
    public Button button;

    void Start()
    {
        button.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        SceneManager.LoadScene("Game");
    }
    // Update is called once per frame
    void Update()
    {
      
    }
}
