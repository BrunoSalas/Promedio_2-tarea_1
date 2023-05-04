using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy3 : Enemy
{
    public GameObject player; 
    public float safeDistance = 5f;
    NavMeshAgent agent;
    Vector3 destination;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public override void Move()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < safeDistance)
        {

            Vector3 direction = transform.position - player.transform.position;
            direction = direction.normalized;


            NavMeshHit hit;
            if (NavMesh.SamplePosition(transform.position + direction * 10f, out hit, 20f, NavMesh.AllAreas))
            {
                destination = hit.position;
            }


            agent.SetDestination(destination);
        }
    }
}
