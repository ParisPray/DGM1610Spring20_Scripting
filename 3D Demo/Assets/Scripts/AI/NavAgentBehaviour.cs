using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class NavAgentBehaviour : MonoBehaviour
{

    private NavMeshAgent agent;
    public Transform player;
    public float speed = 8f;
  
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
    }

    
    void Update()
    {
        agent.destination = player.position;
    }
}
