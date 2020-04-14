﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthScript : MonoBehaviour
{
    public UnityEvent addhealthEvent, subtracthealthEvent, deathEvent;
    public IntData health;

    public void Start()
    {
        health.value = 3;
    
    }

    public void AddHealth()
    {
        if(health.value < 3)
        {
            health.value++;
            addhealthEvent.Invoke();
        }
        
    }

    public void SubtractHealth()
    {
        health.value--;
        subtracthealthEvent.Invoke();
        if(health.value <= 0)
        {
            deathEvent.Invoke();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Treasure"))
        {
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Health"))
        {
            Destroy(other.gameObject);
            AddHealth();
        }

        if (other.CompareTag("Enemy"))
        {
            SubtractHealth();
        }
    }

}
