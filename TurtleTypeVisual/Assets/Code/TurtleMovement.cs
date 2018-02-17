using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleMovement : MonoBehaviour {

    private Rigidbody rgb;
    public float moveSpeed;

	// Use this for initialization
	void Start ()
    {
        rgb = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        bool horT = false;
        bool verT = false;

        if ( hor > 0.5f || hor < -0.5f )
        {
            rgb.velocity = new Vector3(hor * moveSpeed, 0.0f, rgb.velocity.z);
            horT = true;
        }
        else
        {
            rgb.velocity = new Vector3(0.0f, 0.0f, rgb.velocity.z);
        }

        if ( ver > 0.5f || ver < -0.5f)
        {
            rgb.velocity = new Vector3(rgb.velocity.x, 0.0f, ver * moveSpeed);
            verT = true;
        }
        else
        {
            rgb.velocity = new Vector3(rgb.velocity.x, 0.0f, 0.0f);
        }

        if ( horT && verT )
        {
            rgb.velocity *= 0.7f;
        }
	}
}
