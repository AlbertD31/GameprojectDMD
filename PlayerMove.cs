using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private CharacterController2D controller;
    float horizontalMove = 10f;
    public float walkSpeed = 40f;
    bool jump = false;
    private Animator animator; 


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController2D>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var walaking = false;

        horizontalMove = Input.GetAxisRaw("Horizontal") * walkSpeed;

        if (Mathf.Abs(horizontalMove) > 0)
        {
            walaking = true;
        }
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }


        animator.SetBool("isWalking", walaking);


    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
}
