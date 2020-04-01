using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coroutines : MonoBehaviour
{
    public int counter = 3;
    public float seconds = 1f;
    public IntData numberData;
    private WaitForSeconds waitObj;
    public UnityEvent startEvent, repeatEvent, endEvent;

    IEnumerator Start()
    {
        startEvent.Invoke();
        waitObj = new WaitForSeconds(seconds);
       
        while (counter > 0)
        {
            numberData.value = counter;
            yield return waitObj;
            repeatEvent.Invoke();
            counter--;
        }
        yield return waitObj;
        endEvent.Invoke();
    }


}
