using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryRigid : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		if(this.transform.position == new Vector3(3.51f, 0.1392577f, -7.93f))
        {
            Destroy(this.GetComponent<Rigidbody>());
            this.GetComponent<DestoryRigid>().enabled = false;

        }
	}
}
