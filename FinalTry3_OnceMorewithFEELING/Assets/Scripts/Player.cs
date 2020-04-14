using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public UnityEvent enterEvent;
    private float horizontalInput;
    private float forwardInput;
    public float speed = 5f;
    public float turnSpeed = 5f;
    public Vector3 positionDirection;
    public CharacterController Controller;
    public float gravity = -10f;
    public float jumpForce = 10f;
    public UnityEvent jumpEvent;
    public bool gameOver = false;
    
    public void Start()
    {
        
    }
    // unity events.
   

    // basic controls on player character in order to allow testing of unityevents to flow easier.

    private void Update()
    {
        positionDirection.x = Input.GetAxis("Horizontal") * speed;
        Controller.Move(motion: positionDirection * Time.deltaTime);
        positionDirection.y = gravity;
       
        if (Input.GetKeyDown(KeyCode.Space) && !gameOver)
        {
            jumpEvent.Invoke();
            positionDirection.y = jumpForce;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        
    }

   
}