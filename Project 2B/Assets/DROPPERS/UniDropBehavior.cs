using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniDropBehavior : MonoBehaviour
{
    public GameObject playerInfo;
    // Start is called before the first frame update
    void Awake()
    {
        playerInfo = GameObject.Find("PlayerInfo");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -6)
        {
            playerInfo.GetComponent<PlayInfo>().Lives -= 1;
            Destroy(gameObject);
        }
    }
}
