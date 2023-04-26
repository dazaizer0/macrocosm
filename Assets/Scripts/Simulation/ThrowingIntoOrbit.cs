using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingIntoOrbit : MonoBehaviour
{

    public float TIME;
    public float IF_TIME;

    public Vector3 POSITION;

    public Transform ELEMENT;
    private bool DID = false;


    void Update()
    {
    
        if(!DID && TIME >= IF_TIME)
        {

            ELEMENT.position += POSITION;
            TIME = 0;
            DID = true;
        }else
        {

            TIME += 1 * Time.deltaTime;
        }

        if(DID) { TIME = 0f; }
    }

}
