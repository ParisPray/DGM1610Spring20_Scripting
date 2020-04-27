using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pointscript : MonoBehaviour
{
    public IntData Points;
    public UnityEvent addpointsEvent;
    public AudioClip coinSound;
    public AudioSource playerAudio;

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
            playerAudio.PlayOneShot(coinSound, 1.0f);
        }
        else
        {
            print(Points.value);
        }
    }
}
