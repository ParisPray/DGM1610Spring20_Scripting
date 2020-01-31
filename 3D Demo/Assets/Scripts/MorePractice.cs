using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MorePractice : MonoBehaviour
{
    public UnityEvent mouseDownEvent, mouseOverEvent, mouseExitEvent, mouseEnterEvent;
    private float horizontalInput;
    private float forwardInput;
    public float speed = 5;
    public float turnSpeed = 5;
 
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
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

    }
}
