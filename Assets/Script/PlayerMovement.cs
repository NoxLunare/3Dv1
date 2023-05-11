using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private UnityEngine.AI.NavMeshAgent agent;
    [SerializeField] private Transform target;

    void Start()
    {
        agent.SetDestination(target.position);
    }

    void Update()
    {
        
    }
}
