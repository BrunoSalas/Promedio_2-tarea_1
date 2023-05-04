using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy2 : Enemy
{
    public GameObject player;
    public float separationDistance = 2.0f;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        Move();
    }

    public override void Move()
    {
        Vector3 targetPosition = player.transform.position - transform.forward * separationDistance;
        agent.SetDestination(targetPosition);
    }
}
