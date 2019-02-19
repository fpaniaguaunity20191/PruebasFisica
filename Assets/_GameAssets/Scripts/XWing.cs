using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XWing : MonoBehaviour {
    public float speed;
    public float angularSpeed;
    private Rigidbody rb;
    float x, y, z;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        y = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        if (Input.GetMouseButton(0))
        {
            x -= Time.deltaTime * angularSpeed;
        } else if (Input.GetMouseButton(1))
        {
            x += Time.deltaTime * angularSpeed;
        } else
        {
            x = 0;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.forward * speed * z;
        rb.angularVelocity = new Vector3(x, y, 0);
    }

}
