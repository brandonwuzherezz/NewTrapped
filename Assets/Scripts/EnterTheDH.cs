using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterTheDH : MonoBehaviour {

    public static bool dhKey;
    public bool inTrigger;
    public static bool DHlocked = true;
    public MeshRenderer myDoor;
    public Material UnlockedDoor;
    public AudioSource Locked;
    public AudioSource UnLock;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = true;
            if(DHlocked == false)
            {
                print("here");
                SceneManager.LoadScene("5Dining Room");
                LoadLevel.DiningRoom = true;
 
            }
           if(DHlocked == true)
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
        if(DHlocked == false)
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
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        DHlocked = false;
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
            if (!dhKey)
            {
                GUI.Box(new Rect(200, 360, 200, 200), "You need a key to open door");
            }
            if (dhKey && DHlocked)
            {
                GUI.Box(new Rect(200, 360, 200, 200), "Press E to Unlock");
            }
        }
    }
}
