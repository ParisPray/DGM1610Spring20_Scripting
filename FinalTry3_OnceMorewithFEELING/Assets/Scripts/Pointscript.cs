using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pointscript : MonoBehaviour
{
    public IntData Points;
    public UnityEvent addpointsEvent;

    public void Start()
    {
        Points.value = 0;
    }

    public void AddPoints()
    {
        Points.value++;
        addpointsEvent.Invoke();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Treasure"))
        {
            Destroy(other.gameObject);
            AddPoints();
        }
    }
}
