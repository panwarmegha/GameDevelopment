using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour
{
   
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce (Vector3.back * 3);   
    }
}
