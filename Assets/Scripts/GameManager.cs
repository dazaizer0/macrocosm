using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public float TIME_SCALE = 1f;

    void Update()
    {
        
        Time.timeScale = TIME_SCALE;
    }
}
