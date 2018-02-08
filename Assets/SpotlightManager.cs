using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightManager : MonoBehaviour {


    public static bool noBatteries;

    public Light myLight;

    public float maxIntensity = 10f;

    // Use this for initialization
    void Start () {

        noBatteries = false;
        myLight = GetComponent<Light>();

    }
	
	// Update is called once per frame
	void Update () {

        if(noBatteries == true)
        {
            myLight.intensity -= 0.05f;
        }
        else
        {
            myLight.intensity = maxIntensity;
        }
		
	}
}
