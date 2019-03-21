using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class closeOptions : MonoBehaviour
{
    public Button button;
    public GameObject OPCanvas;
    void Start()
    {
        button.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        OPCanvas.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {

    }
}