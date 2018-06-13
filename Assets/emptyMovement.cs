using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emptyMovement : MonoBehaviour {

    public float maxSpeed;

	void Update () {
        if (Input.GetKey("a"))
            transform.position -= transform.right * Time.deltaTime * maxSpeed;
        else if (Input.GetKey("d"))
            transform.position += transform.right * Time.deltaTime * maxSpeed;
        else if (Input.GetKey("w"))
            transform.position += transform.forward * Time.deltaTime * maxSpeed;
        else if (Input.GetKey("s"))
            transform.position -= transform.forward * Time.deltaTime * maxSpeed;
    }
}
