using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{

    public float force;
    public float z_force;
    public float x_force;
    public Rigidbody rb;
    public Transform top;

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();


    }

    void Update()
    {
        
        if(Input.GetKey(KeyCode.UpArrow))
            force += 0.05f;
            Debug.Log("Up");
        if(Input.GetKey(KeyCode.DownArrow))
            force -= 0.05f;
            Debug.Log("Down");
        
        if(Input.GetKey(KeyCode.D))
            z_force -= 0.01f;
            Debug.Log("Right");

        if(Input.GetKey(KeyCode.A))
            z_force += 0.01f;
            Debug.Log("Left");

         if(Input.GetKey(KeyCode.W))
            x_force += 0.01f;
            Debug.Log("Right");

        if(Input.GetKey(KeyCode.S))
            x_force -= 0.01f;
            Debug.Log("Left");

    }

    void FixedUpdate()
    {
    
        Vector3 force_vector = new Vector3(top.position.x, force + top.position.y, top.position.z);

        transform.Rotate(x_force, 0f, z_force);

        if(force > 0)
            rb.velocity = (force_vector + top.position) * Time.deltaTime;
        else if(force < 0 && force > -29)
            rb.velocity = -(force_vector + top.position) * Time.deltaTime;
        else
            rb.velocity = rb.velocity;
        
        Vector3 dir = new Vector3(top.position.x, top.position.y, top.position.z);
        Debug.DrawLine(transform.position, dir, Color.red, 1f);
    }
}
