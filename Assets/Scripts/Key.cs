using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    public bool inTrigger;
    public static List<string> DeleteKeys = new List<string>();
    //public static int keys = 0;
    public AudioSource keySound;
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
        print(EnterBarricadeDH.dhKey);
        if (EnterBarricadeDH.dhKey == true)
        {
            Destroy(gameObject);
        }

    }


    void Update()
    {
        if (inTrigger)
        {
           
                EnterBarricadeDH.dhKey = true;
                DeleteKeys.Add(gameObject.name);
                keySound.Play();
                Destroy(gameObject);
                KeyManager.isImgOn = true;
          
        }    
    }

    

}
