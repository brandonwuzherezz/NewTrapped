using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryManager : MonoBehaviour {

    // Use this for initialization

    public static int battery = 0;

    Text text;


    void Start () {

        text = GetComponent<Text>();
        battery = battery;
		
	}
	
	// Update is called once per frame
	void Update () {

        text.text = ": " + battery;
		
	}
}
