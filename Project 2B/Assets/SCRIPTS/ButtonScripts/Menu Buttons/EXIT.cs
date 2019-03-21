using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EXIT : MonoBehaviour
{
    public Button exit;

    public void OnMouseUpAsButton()
    {
        exit.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
