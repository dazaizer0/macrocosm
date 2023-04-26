using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F : MonoBehaviour
{
    
    public static float G = 6.67430f;
    public static float F_;
    public static List<F> ATTRACTORS;
    //CENTER CAN BE KINEMATIC
    public Rigidbody rb;


    void FixedUpdate()
    {
        
        foreach(F ATTRACTOR in ATTRACTORS)
        {

            if(ATTRACTOR != this) { ATTRACT(ATTRACTOR); }
        }
    }

    void OnEnable()
    {
        
        if(ATTRACTORS == null) { ATTRACTORS = new List<F>(); }
        ATTRACTORS.Add(this);
    }

    void ATTRACT(F PHYSIC_OBJECT)
    {

        Rigidbody PHYSIC_OBJECT_TO_ATTRACT = PHYSIC_OBJECT.rb;
        
        Vector3 DIRECTION = rb.position - PHYSIC_OBJECT_TO_ATTRACT.position;
        float DISTANCE = DIRECTION.magnitude;

        if (DISTANCE == 0f) { return; }

        float FORCE_MAGNITUDE = (G * (rb.mass * PHYSIC_OBJECT_TO_ATTRACT.mass) / Mathf.Pow(DISTANCE, 2));
        F_ = FORCE_MAGNITUDE;
        Vector3 FORCE = DIRECTION.normalized * FORCE_MAGNITUDE;

        PHYSIC_OBJECT_TO_ATTRACT.AddForce(FORCE);
    }
}