using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public Transform target;
    public Vector3 offset;

    void Start()
    {
        
    }

    void Update()
    {

        Vector3 position = new Vector3(target.position.x, target.position.y, 0f);
        transform.position = position + offset;
    }
}
