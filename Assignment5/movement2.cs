using UnityEngine;
using System.Collections;

public class movement2 : MonoBehaviour
{

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(Vector3.forward * 5);
    }
}

