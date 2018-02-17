using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public GameObject followingObject;
    public float moveSpeed;

    private float yD;
    private float zD;

    private void Awake()
    {
        yD = transform.position.y;
        zD = transform.position.z;
    }

	void FixedUpdate ()
    {
        Vector3 newPosition = followingObject.transform.position;
        newPosition.y += yD;
        newPosition.z += zD;
        transform.position = Vector3.Lerp(transform.position, newPosition, moveSpeed * Time.deltaTime);
	}
}
