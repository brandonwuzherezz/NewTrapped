using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonC : MonoBehaviour {
    public bool inTrigger;
    public Light LightA;
    public Light LightB;
    public Light LightC;
    public AudioSource Cnoise;
    public RawImage MyRaw;

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
        LightB = GameObject.Find("Spot Light B").GetComponent<Light>();
        LightC = GameObject.Find("Spot Light C").GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inTrigger)
        {
            MyRaw.enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                Cnoise.Play();
                ButtonA.B_Active = !ButtonA.B_Active;
                ButtonA.C_Active = !ButtonA.C_Active;
                LightB.enabled = ButtonA.B_Active;
                LightC.enabled = ButtonA.C_Active;

            }
        }
        else
        {
            MyRaw.enabled = false;
        }
    }
  
}
