using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MorePractice : MonoBehaviour
{
    public UnityEvent mouseDownEvent, mouseOverEvent, mouseExitEvent, mouseEnterEvent;
    private float horizontalInput;
    private float forwardInput;
    public float speed = 5f;
    public float turnSpeed = 5f;
    public Vector3 positionDirection;
    public CharacterController Controller;
    public float gravity = -10f;
    public float jumpForce = 10f;
 
    // unity events.
    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();

    }

    private void OnMouseOver()
    {
        mouseOverEvent.Invoke();
    }

    private void OnMouseExit()
    {
        mouseExitEvent.Invoke(); 
    }
    private void OnMouseEnter()
    {
        mouseEnterEvent.Invoke();
    }

    // basic controls on player character in order to allow testing of unityevents to flow easier.

    private void Update()
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
