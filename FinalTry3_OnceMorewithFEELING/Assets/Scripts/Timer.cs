using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public int counter = 3;
    public float seconds = 1f;
    public IntData numberData;
    private WaitForSeconds waitObj;
    public UnityEvent startEvent, repeatEvent, endEvent;
    float currCountdownValue;

    public IEnumerator StartCountdown(float countdownValue = 10)
    {
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            Debug.Log("Countdown: " + currCountdownValue);
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;
        }
    }
}
