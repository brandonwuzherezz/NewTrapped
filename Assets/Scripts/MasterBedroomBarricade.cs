using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MasterBedroomBarricade : MonoBehaviour {

    public static bool vaultKey;
    public bool inTrigger;
    public static bool vaultlocked = true;
    public MeshRenderer myDoor;
    public Material UnlockedDoor;
    public AudioSource Locked;
    public AudioSource UnLock;
    public RawImage MyRaw;
    public RawImage MyRawr;
    public static bool BarrDestroyed = false;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = true;
            if (vaultlocked == true)
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
        if (vaultlocked == false)
        {
            myDoor.material = UnlockedDoor;
        }
    }
    void Update()
    {
        if (vaultlocked)
        {
            if (inTrigger)
            {
                if (vaultKey)
                {
                    if (vaultlocked)
                    {
                        MyRaw.enabled = true;
                    }
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        vaultlocked = false;
                        KeyManager.isImgOn = false;
                        //image changing code
                        myDoor.material = UnlockedDoor;
                        //play soundeffect
                        BarrDestroyed = true;
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
        if(BarrDestroyed == true)
        {
            Destroy(gameObject);
        }
    }
   
}
