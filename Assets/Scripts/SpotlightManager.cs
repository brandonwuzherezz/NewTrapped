using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightManager : MonoBehaviour {


    public static bool noBatteries;

    public Light myLight;

    public float maxIntensity = 10f;

    public float duration = .025f;

    public Color rcolor = Color.red;
    public Color wcolor = Color.white;

    // Use this for initialization
    void Start () {

        noBatteries = false;
        myLight = GetComponent<Light>();

    }
	
	// Update is called once per frame
	void Update () {

        if(noBatteries == true)
        {

            float t = Mathf.PingPong(Time.time,duration);
            myLight.color = Color.Lerp(rcolor, wcolor, t);
            myLight.intensity -= 0.05f;
            
        }
        else
        {
            myLight.intensity = maxIntensity;
            myLight.color = wcolor;

        }
		
	}
}
