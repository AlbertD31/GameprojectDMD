using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowPlayer : MonoBehaviour
{

    GameObject  player;
    Vector3 playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        

        if (player != null && player.transform.position.y > -2f)
        {
            playerPosition = new Vector3 (player.transform.position.x, player.transform.position.y, gameObject.transform.position.z);

            gameObject.transform.position = playerPosition;
        }


    }
}
