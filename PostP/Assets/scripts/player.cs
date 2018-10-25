using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public Rigidbody rb;
    public float fuerza_torque = 10f;
    public void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    public void FixedUpdate()
    {
        Controles();
        
    }
    void Controles()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddTorque(new Vector3(fuerza_torque, 0,0), ForceMode.Impulse);
        }
    }
}
