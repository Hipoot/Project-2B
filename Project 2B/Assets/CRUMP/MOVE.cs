using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE : MonoBehaviour
{
    public GameObject playerInfo;
    public AudioSource sound;
    private Vector3 MousePosition;
    //public GameObject crumpSprite;
    private float Y = -3.92f;
    public bool MovementEnabled = false;
    private bool GameStarted = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameStarted == false)
        {
            GameStarted = true;
            MovementEnabled = true;
        }
        if (MovementEnabled == true)
        {
            MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(MousePosition.x, Y, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("SPDropper"))
        {
            playerInfo.GetComponent<PlayInfo>().Score += 1;
            sound.Play();
            Destroy(collision.gameObject);
        }
        
    }
}
