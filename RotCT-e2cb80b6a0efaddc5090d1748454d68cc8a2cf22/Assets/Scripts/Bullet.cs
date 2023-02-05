using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody _rb => GetComponent<Rigidbody>();

    private void Start()
    {
        Destroy(gameObject, 4.5f);
    }

    void FixedUpdate()
    {
        _rb.AddForce(transform.forward* 10000 * Time.fixedDeltaTime);
    }
}
