using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 movementDirection;
    public float movementSpeed;
    public Rigidbody2D rb;
    public Animator animator;

    void Start()
    {
        
    }

    void Update()
    {
        
        
    }

    private void FixedUpdate()
    {
        ProcessInputs();
        Move();
        Animate();
    }

    void ProcessInputs()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        movementDirection.Normalize();
    }

    void Move()
    {
        rb.velocity = movementDirection * movementSpeed;
    }

    void Animate()
    {
        if (movementDirection != Vector2.zero)
        {
            animator.SetFloat("Horizontal", movementDirection.x);
            animator.SetFloat("Vertical", movementDirection.y);
            animator.SetFloat("Speed", movementSpeed);
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }
    }
}
