using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJSController : MonoBehaviour
{
    private Vector3 movementVector;
    private Animator animator;
    public JoyStickController js;
    private Rigidbody2D _rigidBody;
    public float speed = 3f;
    private LastDirection lr = LastDirection.Right;

    enum LastDirection
    {
        Right,
        Left
    }

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    void FixedUpdate()
    {
        float h = js.Horizontal();
        if (h != 0)
            Debug.Log("h="+h);
        float v = js.Vertical();
        if (v != 0)
            Debug.Log("v="+v+"\n");

        speed = 3f;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 5f;
        }

        Move(h, v);
        PlayAnimation(h, v);
    }

    void PlayAnimation(float h, float v)
    {
        if (h >= -0.31 && h <= 0.31 && v > 0)
        {
            animator.SetBool("IsWalkingTop", true);
        }
        else
        {
            animator.SetBool("IsWalkingTop", false);
        }
        if (h >= -0.31 && h <= 0.31 && v < 0)
        {
            animator.SetBool("IsWalkingBot", true);
        }
        else
        {
            animator.SetBool("IsWalkingBot", false);
        }

        if (h <= -0.31 && (v >= 0 || v <= 0))
        {
            animator.SetBool("IsWalkingLeft", true);
        }
        else
        {
            animator.SetBool("IsWalkingLeft", false);
        }

       
        if (h >= 0.31 && (v >= 0 || v <= 0))
        {
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }
    }

    void Move(float h, float v)
    {
        movementVector.Set(h, v, 0f);
        movementVector = movementVector.normalized * speed * Time.deltaTime;
        _rigidBody.MovePosition(transform.position + movementVector);
    }
}