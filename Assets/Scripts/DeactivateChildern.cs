using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateChildern : MonoBehaviour {
	// Update is called once per frame
	void Update () {
        foreach (Transform child in this.transform)
        {
            if (ActivateFlashlight.hasFlashlight == false)
            {
                child.gameObject.SetActive(false);
            }
            else 
            {
                child.gameObject.SetActive(true);
            }
        }
    }
}

