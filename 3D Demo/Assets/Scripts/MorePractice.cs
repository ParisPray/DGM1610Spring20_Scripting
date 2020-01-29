using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MorePractice : MonoBehaviour
{
    public UnityEvent mouseDownEvent, mouseOverEvent, mouseExitEvent, mouseEnterEvent;
 

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
        mouseEnterEvent.Invoke;
    }
}
