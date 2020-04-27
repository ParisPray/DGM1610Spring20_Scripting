using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthScript : MonoBehaviour
{
    public UnityEvent addhealthEvent, subtracthealthEvent, deathEvent;
    public IntData health;
    public ParticleSystem explosionParticle;
    public AudioSource playerAudio;
    public AudioClip healthSound;
    public AudioClip damageSound;
    public AudioClip deathSound;
   

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
        explosionParticle.Play();
        if (health.value <= 0)
        {
            deathEvent.Invoke();
            playerAudio.PlayOneShot(deathSound, 1.0f);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
      

        if (other.CompareTag("Health"))
        {
            Destroy(other.gameObject);
            AddHealth();
            playerAudio.PlayOneShot(healthSound, 1.0f);
        }

        if (other.CompareTag("Enemy"))
        {
            SubtractHealth();
            playerAudio.PlayOneShot(damageSound, 1.0f);
        }
    }

}

