using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHealth : MonoBehaviour
{

    PlayerHealth playerHealth;
    bool healthAdded;   


    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        

        healthAdded = true;
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && healthAdded)
        {
            healthAdded = false;
            Debug.Log("Health added!");

            

            if (playerHealth != null)
            {
                playerHealth.AddHealth(50);

            }
            DestroyPlayer();
        }
    }

    void DestroyPlayer()
    {

        gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
        gameObject.GetComponentInChildren<Collider2D>().enabled = false;

    }

}