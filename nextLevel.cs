using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLevel : MonoBehaviour
{
    HealthManager healthManager;
    Animator animator;
    bool startAnimation = true;

    // Start is called before the first frame update
    void Start()
    {
        healthManager = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthManager>();
        animator = GetComponent<Animator>();

    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Player" && startAnimation)
        {
            if (healthManager != null)
            {
                healthManager.PlayerWins();
                animator.SetBool("OpenChest", startAnimation);
                startAnimation = false;
            }

        }
    }
}
