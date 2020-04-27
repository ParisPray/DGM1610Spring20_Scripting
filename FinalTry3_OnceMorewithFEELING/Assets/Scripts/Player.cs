using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public UnityEvent enterEvent, endEvent;
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
    public Animator playerAnimator;
    public GameObject groundCheck;
    public bool isGrounded;
    public float groundCheckRadius;
    public AudioClip jumpSound;
    public AudioSource playerAudio;
    public AudioClip endSound;
    // basic controls on player character in order to allow testing of unityevents to flow easier.

    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.transform.position, groundCheckRadius);

        if (isGrounded)
        {
            playerAnimator.SetBool("isJumping", false);
        }
        else
        {
            playerAnimator.SetBool("isRunning", false);
        }

        positionDirection.x = Input.GetAxis("Horizontal") * speed;
        
        if(positionDirection.x != 0 && isGrounded)
        {
            playerAnimator.SetBool("isRunning", true);
        }
        else if(positionDirection.x == 0 && isGrounded)
        {
            playerAnimator.SetBool("isRunning", false);
        }
        Controller.Move(motion: positionDirection * Time.deltaTime);
        positionDirection.y = gravity;
       
        if (Input.GetKeyDown(KeyCode.Space) && !gameOver)
        {
            jumpEvent.Invoke();
            positionDirection.y = jumpForce;
            //playerAnimator.SetBool("isRunning", false);
            playerAnimator.SetBool("isJumping", true);
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("End"))
        {
            endEvent.Invoke();
            playerAudio.PlayOneShot(endSound, 1.0f);
        }
    }



}