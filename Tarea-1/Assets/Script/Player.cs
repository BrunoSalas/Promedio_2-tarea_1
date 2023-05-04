using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int life;
    private Rigidbody rb;

    [Range(1,100)]
    public float velocity = 5;

    void Start () 
    {
        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate () 
    {

        float movementH = Input.GetAxis("Horizontal");
        float movementV = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movementH * velocity, 0.0f, movementV * velocity);

        rb.AddForce(movement);

    }
    /*private void OnCollisionEnter( collision collesion)
    {
        
    }*/
}
