using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public UnityEvent startEvent, counterdownEvent, deathEvent;
    float currCountdownValue;
    public IntData time;
    public int maxTime;

    public void Start()
    {
        time.value = maxTime;
        StartCountdown();
    }

    public void StartCountdown()
    {
        StartCoroutine(Countdown());
    }

    public IEnumerator Countdown()
    {
        while (time.value > 0)
        {
            counterdownEvent.Invoke();
            yield return new WaitForSeconds(1.0f);
            time.value--;
        }
        deathEvent.Invoke();
    }
}
