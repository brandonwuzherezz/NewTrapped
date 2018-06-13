using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class KitchenBarricade : MonoBehaviour {

    public static bool KitchenKey;
    public bool inTrigger;
    public static bool Kitchenlocked = true;
    public MeshRenderer myDoor;
    public Material UnlockedDoor;
    public AudioSource Locked;
    public AudioSource UnLock;
    public RawImage MyRaw;
    public RawImage MyRawr;
    public static bool KitchenDestroyed = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = true;
            if (Kitchenlocked == true)
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
    void Start()
    {
        if (Kitchenlocked == false)
        {
            myDoor.material = UnlockedDoor;
        }
    }
    void Update()
    {
        if (Kitchenlocked)
        {
            if (inTrigger)
            {
                if (KitchenKey)
                {
                    if (Kitchenlocked)
                    {
                        MyRaw.enabled = true;
                    }
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Kitchenlocked = false;
                        KeyManager.isImgOn = false;
                        //image changing code
                        myDoor.material = UnlockedDoor;
                        //play soundeffect
                        UnLock.Play();
                        KitchenDestroyed = true;

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
        if(KitchenDestroyed == true)
        {
            Destroy(gameObject);
        }

    }
    
}
