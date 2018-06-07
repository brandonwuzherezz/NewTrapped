using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnterBarricadeDH : MonoBehaviour {

    public static bool dhKey;
    public bool inTrigger;
    public static bool DHlocked = true;
    public MeshRenderer myDoor;
    public Material UnlockedDoor;
    public AudioSource Locked;
    public AudioSource UnLock;
    public static bool DHDestroyed = false;
    public RawImage MyRaw;
    public RawImage MyRawr;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = true;
            if (DHlocked == true)
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
        if (DHlocked == false)
        {
            myDoor.material = UnlockedDoor;
        }
    }
    void Update()
    {
        if (DHlocked)
        {
            if (inTrigger)
            {
                if (dhKey)
                {
                    if (DHlocked)
                    {
                        MyRaw.enabled = true;
                    }
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        DHlocked = false;
                        KeyManager.isImgOn = false;
                        //image changing code
                        myDoor.material = UnlockedDoor;
                        //play soundeffect
                        UnLock.Play();
                        DHDestroyed = true;


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
        if (DHDestroyed == true)
        {
            Destroy(gameObject);
        }
    }
    
}
