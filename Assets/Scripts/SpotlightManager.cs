using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightManager : MonoBehaviour {


    public static bool noBatteries;

    public static Light mySpotLight;

    public float maxIntensity = 10f;

    public float duration = .025f;

    public Color rcolor = Color.red;
    public Color wcolor = Color.white;

    // Use this for initialization
    void Start () {

        noBatteries = false;
        mySpotLight = GetComponent<Light>();
        mySpotLight.enabled = false;

    }
	
	// Update is called once per frame
	void Update () {
        mySpotLight.enabled = true;
        /* if(noBatteries == true)
         {

             float t = Mathf.PingPong(Time.time,duration);
             mySpotLight.color = Color.Lerp(rcolor, wcolor, t);
             mySpotLight.intensity -= 0.05f;

         }
         else
         {
             mySpotLight.intensity = maxIntensity;
             mySpotLight.color = wcolor;

         }*/

    }
}
