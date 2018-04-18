using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyManager : MonoBehaviour {

    public static bool isImgOn;
    public Image img;
    
    
    // Use this for initialization
	void Start () {

        if (isImgOn == true)
        {
            img.enabled = true;
        }
        else
        {
            img.enabled = false;
        }

    }
	
	// Update is called once per frame
	void Update () {

        if (isImgOn == true)
        {
            img.enabled = true;
        }
        else
        {
            img.enabled = false;
        }
		
	}
}
