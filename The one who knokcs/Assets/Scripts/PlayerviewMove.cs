using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

public class PlayerviewMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public float speed = 5f;
    private CharacterController Controller;
    Vector3 velocity;
    float gravity = -20f;
    bool IsGround;
    public float Jumpheight = 3f;
    private float x;
    private float y;
    private bool _jumpPressed = false;
    public bool Analise;
   // private float jumpForce = 20f;

    void Start()
    {
        this.animator = GetComponent<Animator>();
        Controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        animator.SetFloat("vertical", x);
        animator.SetFloat("horizontal", y);

        if (Controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        Vector3 move = transform.right * x + transform.forward * y;
        Controller.Move(move * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        Controller.Move(velocity * Time.deltaTime);
    }

    public void OnPlayerMove(InputValue value)
    {
        x = value.Get<Vector2>().x;
        y = value.Get<Vector2>().y;
    }

    void OnJump()
    {
        

        // Check if no vertical movement
        if (Controller.velocity.y == 0)
       
        velocity.y += Jumpheight;
           
            _jumpPressed = true;
        }
        void OnInteract(){
            Analise = true;

        }
     
    }
