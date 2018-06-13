using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonA : MonoBehaviour {
    public bool inTrigger;
    public Light LightA;
    public Light LightB;
    public static bool A_Active = false;
    public static bool B_Active = true;
    public static bool C_Active = false;
    public AudioSource ANoise;
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
        LightA = GameObject.Find("Spot Light A").GetComponent<Light>();
        LightB = GameObject.Find("Spot Light B").GetComponent<Light>();
    }

    // Update is called once per frame
    void Update () {
        if (inTrigger)
        {
            MyRaw.enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                ANoise.Play();
                A_Active = !A_Active;
                B_Active = !B_Active;
                LightA.enabled = A_Active;
                LightB.enabled = B_Active;
            }
        }
        if(inTrigger == false)
        {
            MyRaw.enabled = false;
        }
    }
   
}
