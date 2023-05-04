using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public abstract class Bullet : MonoBehaviour
{

    protected Rigidbody rb;
    [SerializeField] protected float speed;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    protected virtual void  Update()
   {
        
   }
}
