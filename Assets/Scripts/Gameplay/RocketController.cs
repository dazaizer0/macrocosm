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
            force += 0.01f;
            Debug.Log("Up");
        if(Input.GetKey(KeyCode.DownArrow))
            force -= 0.01f;
            Debug.Log("Down");
        
        if(Input.GetKey(KeyCode.D))
            z_force -= 0.01f / 2;
            Debug.Log("Right");
        if(Input.GetKey(KeyCode.A))
            z_force += 0.01f / 2;
            Debug.Log("Left");

         if(Input.GetKey(KeyCode.W))
            x_force += 0.01f / 2;
            Debug.Log("Right");
        if(Input.GetKey(KeyCode.S))
            x_force -= 0.01f / 2;
            Debug.Log("Left");

        if(Input.GetKey(KeyCode.Z))
            force = 0;
            Debug.Log("ZERO");
    }

    void FixedUpdate()
    {

        transform.Rotate(x_force, 0f, z_force);

        if(force > 0)
            rb.velocity = top.position * force * Time.deltaTime;
        else if(force < 0 && force > -29)
            rb.velocity = -(top.position * force) * Time.deltaTime;

        else
            rb.velocity = rb.velocity;
        
        Vector3 dir = new Vector3(top.position.x, top.position.y, top.position.z);
        Debug.DrawLine(transform.position, dir, Color.red, 1f);
    }
}
