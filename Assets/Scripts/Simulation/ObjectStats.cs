using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class ObjectStats : MonoBehaviour
{

    public TextMeshProUGUI VELOCITY_TEXT;
    public TextMeshProUGUI MASS_TEXT;
    public Rigidbody rb;
    public bool notKINEMATIC;

    void Start()
    {
        
    }

    void Update()
    {
        
        VELOCITY_TEXT.text = rb.velocity.magnitude.ToString();
        MASS_TEXT.text = rb.mass.ToString();
    }

    public void KIN()
    {

        if(notKINEMATIC == true)
        {

            rb.isKinematic = false;
            notKINEMATIC = false;
        }else if (notKINEMATIC == false)
        {

            rb.isKinematic = true;
            notKINEMATIC = true;
        }
    }
}
