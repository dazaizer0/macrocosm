using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F : MonoBehaviour
{
    
    const float G = 6.67430f;
    public static List<F> ATTRACTORS;
    public Rigidbody rb;


    void FixedUpdate()
    {
        
        foreach(F ATTRACTOR in ATTRACTORS)
        {

            if(ATTRACTOR != this) { Attract(ATTRACTOR); }
        }
    }

    void OnEnable()
    {
        
        if(ATTRACTORS == null) { ATTRACTORS = new List<F>(); }
        ATTRACTORS.Add(this);
    }

    void Attract(F ATTRACTABLE_OBJECT)
    {

        Rigidbody rb_TO_ATTRACT = ATTRACTABLE_OBJECT.rb;
        Vector3 DIRECTION = rb.position - rb_TO_ATTRACT.position;
        float DISTANCE = DIRECTION.magnitude;

        if (DISTANCE == 0f) { return; }

        float FORCE_MAGNITUDE = (G * (rb.mass * rb_TO_ATTRACT.mass) / Mathf.Pow(DISTANCE, 2));
        Vector3 FORCE = DIRECTION.normalized * FORCE_MAGNITUDE;

        rb_TO_ATTRACT.AddForce(FORCE);
    }
}