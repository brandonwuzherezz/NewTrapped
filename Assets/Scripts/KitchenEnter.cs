using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KitchenEnter : MonoBehaviour
{
    public static bool KitchenKey;
    public bool inTrigger;
    public static bool Kitchenlocked = true;
    public MeshRenderer myDoor;
    public Material UnlockedDoor;
    public AudioSource Locked;
    public AudioSource UnLock;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = true;
            if (Kitchenlocked == false)
            {
                SceneManager.LoadScene("Kitchen");
                LoadLevel.Kitchen = true;
            }
            if(Kitchenlocked == true)
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
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Kitchenlocked = false;
                        KeyManager.isImgOn = false;
                        //image changing code
                        myDoor.material = UnlockedDoor;
                        //play soundeffect
                        UnLock.Play();
                    }
                }

            }
        }

    }
    void OnGUI()
    {
        if (inTrigger)
        {
            if (!KitchenKey)
            {
                GUI.Box(new Rect(200, 360, 200, 200), "You need a key to open door");
            }
            if(KitchenKey && Kitchenlocked)
            {
                GUI.Box(new Rect(200, 360, 200, 200), "Press E to Unlock");
            }
        }
    }
}