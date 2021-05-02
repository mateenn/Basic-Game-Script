﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed = 2.0f;
    [SerializeField]
    private float jumpHeight = 1.0f;
    [SerializeField]
    private float gravityValue = -9.81f;

   // private Transform cameraMain;

    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;

    static Animator anim;


    private Player playerInput;

    private void Awake()
    {
        playerInput = new Player();
        controller = GetComponent<CharacterController>();
        anim =  GetComponent<Animator>();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }



    private void Start()
    {
      //  cameraMain = GetComponent<Camera>().main.transform;    
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;

        }

        Vector2 movementInput = playerInput.PlayerMain.Move.ReadValue<Vector2>();

        Vector3 move = new Vector3(movementInput.x, 0f, movementInput.y);
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
             anim.SetBool("isWalking", true);
             anim.SetBool("isIdle", false);
            gameObject.transform.forward = move;

        }
        else
        {
             anim.SetBool("isWalking", false);
             anim.SetBool("isIdle", true);

        }

        // Changes the height position of the player..
        if (playerInput.PlayerMain.Jump.triggered && groundedPlayer)
        {
         anim.SetTrigger("isJumping");
        }
        
           
        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}
