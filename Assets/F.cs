using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F : MonoBehaviour
{

    public float G = 66.7430f;

    Rigidbody OBJECT_ONE;
     Rigidbody OBJECT_TWO;

    void FixedUpdate()
    {
        
        GRAVITY_FORCE(OBJECT_ONE, OBJECT_TWO, G);
    }

    public void GRAVITY_FORCE(Rigidbody OBJECT_ONE, Rigidbody OBJECT_TWO, float G)
    {

        Vector3 DIRECTION = OBJECT_ONE.position - OBJECT_TWO.position;
        float DISTANCE = DIRECTION.magnitude;

        float silaPrzyciagania = (G * (OBJECT_ONE.mass * OBJECT_TWO.mass)) / Mathf.Pow(DISTANCE, 2f);

        Vector3 FORCE = DIRECTION.normalized * silaPrzyciagania;

        OBJECT_ONE.AddForce(-FORCE);
        OBJECT_TWO.AddForce(FORCE);
    }
}
