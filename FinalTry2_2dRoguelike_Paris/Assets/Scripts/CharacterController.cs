﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterController : MonoBehaviour
{
    private float horizontalInput;
    private float forwardInput;
    public float speed = 5f;
    public float turnSpeed = 5f;
    public Vector3 positionDirection;
    public CharacterController Controller;
    public float gravity = -10f;
    public float jumpForce = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        positionDirection.x = Input.GetAxis("Horizontal") * speed;
        Controller.Move(motion: positionDirection * Time.deltaTime);
        positionDirection.y = gravity;

        if (Input.GetButtonDown("Jump"))
        {
            positionDirection.y = jumpForce;
        }
    }
}
