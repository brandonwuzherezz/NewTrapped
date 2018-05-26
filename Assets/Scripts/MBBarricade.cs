using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MBBarricade : MonoBehaviour {

    public static bool MBKey;
    public bool inTrigger;
    public static bool MBlocked = true;
    public AudioSource Locked;
    public AudioSource UnLock;
    public static bool MBdestroyed = false;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = true;
            if (MBlocked == true)
            {
                Locked.Play();
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = false;
        }
    }

    void Update()
    {
        if (MBlocked)
        {
            if (inTrigger)
            {
                if (MBKey)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        MBlocked = false;
                        KeyManager.isImgOn = false;
                        //image changing code
                        //play soundeffect
                        MBdestroyed = true;
                        UnLock.Play();
                    }
                }

            }
        }
        if(MBdestroyed == true)
        {
            Destroy(gameObject);
        }
    }
    void OnGUI()
    {
        if (inTrigger)
        {
            if (!MBKey)
            {
                GUI.Box(new Rect(200, 360, 200, 200), "You need a key to open door");
            }
            if (MBKey && MBlocked)
            {
                GUI.Box(new Rect(200, 360, 200, 200), "Press E to Unlock");
            }
        }
    }
}
