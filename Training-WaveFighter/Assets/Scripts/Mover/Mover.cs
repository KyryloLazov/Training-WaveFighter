using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    private NavMeshAgent agent;
    
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void MoveTo(Vector3 dest, float speed)
    {
        agent.SetDestination(dest);
        agent.speed = speed;
        agent.isStopped = false;           
    }

    public void StopMoving()
    {
        agent.isStopped = true;
    }
}
