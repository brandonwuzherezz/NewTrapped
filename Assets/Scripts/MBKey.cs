using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MBKey : MonoBehaviour {

    public bool inTrigger;
    //public static int keys = 0;
    public AudioSource MBnoise;
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
        if (Key.DeleteKeys.Contains(gameObject.name))
        {
            Destroy(gameObject);
        }

    }

    void Update()
    {
        if (inTrigger)
        {
            
                MBBarricade.MBKey = true;
                Key.DeleteKeys.Add(gameObject.name);
                MBnoise.Play();
                Destroy(gameObject);
                KeyManager.isImgOn = true;
           
        }
    }

    void OnGUI()
    {
        if (inTrigger)
        {
            GUI.Box(new Rect(200, 360, 200, 200), "Press E to take key");
        }
    }

}
