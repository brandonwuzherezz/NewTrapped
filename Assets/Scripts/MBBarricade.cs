using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MBBarricade : MonoBehaviour {

    public static bool MBKey;
    public bool inTrigger;
    public static bool MBlocked = true;
    public AudioSource Locked;
    public AudioSource UnLock;
    public static bool MBdestroyed = false;
    public RawImage MyRaw;
    public RawImage MyRawr;

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
                    if (MBlocked)
                    {
                        MyRaw.enabled = true;
                    }
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        MBlocked = false;
                        KeyManager.isImgOn = false;
                        //image changing code
                        //play soundeffect
                        MBdestroyed = true;
                        MyRaw.enabled = false;
                        MyRawr.enabled = false;
                        UnLock.Play();
                    }
                }
                else
                {
                  
                        MyRawr.enabled = true;
                   
                }

            }
            else
            {
                MyRaw.enabled = false;
                MyRawr.enabled = false;
            }
        }
        if(MBdestroyed == true)
        {
            MyRaw.enabled = false;
            MyRawr.enabled = false;
            Destroy(gameObject);
        }
    }
   
}
