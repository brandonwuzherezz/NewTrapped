using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonB : MonoBehaviour {
    public bool inTrigger;
    public Light LightA;
    public Light LightB;
    public Light LightC;
    public AudioSource Bnoise;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = false;
        }
    }
    void Start()
    {
        LightA = GameObject.Find("Spot Light A").GetComponent<Light>();
        LightB = GameObject.Find("Spot Light B").GetComponent<Light>();
        LightC = GameObject.Find("Spot Light C").GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Bnoise.Play();
                ButtonA.A_Active = !ButtonA.A_Active;
                ButtonA.B_Active = !ButtonA.B_Active;
                ButtonA.C_Active = !ButtonA.C_Active;
                LightA.enabled = ButtonA.A_Active;
                LightB.enabled = ButtonA.B_Active;
                LightC.enabled = ButtonA.C_Active;

            }
        }
    }
    void OnGUI()
    {
        if (inTrigger)
        {
            GUI.Box(new Rect(200, 360, 200, 200), "Press E to push");
        }
    }
}
