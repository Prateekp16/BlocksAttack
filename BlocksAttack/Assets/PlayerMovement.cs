using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float sidewaysforce = 500f;
   
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
    }
}
