using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryPlatform : MonoBehaviour {
    public ButtonA ScriptA;
    public ButtonB ScriptB;
    public ButtonC ScriptC;
    public Light LightA;
    public Light LightB;
    public Light LightC;
    public GameObject Item;
    public static bool Solved = false;
    void Start()
    {
        Item = GameObject.Find("PantryKey");
        if (Solved == true)
        {
            LightA.enabled = true;
            LightB.enabled = true;
            LightC.enabled = true;
            ScriptA.enabled = false;
            ScriptB.enabled = false;
            ScriptC.enabled = false;
            Item.transform.position = new Vector3(3.51f, 0.1392577f, -7.93f);
            Destroy(gameObject);
        }
    }
    void Update () {
		if(ButtonA.A_Active == true && ButtonA.B_Active == true && ButtonA.C_Active == true)
        {
            ScriptA.enabled = false;
            ScriptB.enabled = false;
            ScriptC.enabled = false;
            Solved = true;
            Destroy(gameObject);

        }
	}
}
