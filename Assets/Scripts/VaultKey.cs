using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaultKey : MonoBehaviour {

    public bool inTrigger;
    //public static int keys = 0;
    public AudioSource Vaultnoise;
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

                MasterBedroomBarricade.vaultKey = true;
                Key.DeleteKeys.Add(gameObject.name);
                Vaultnoise.Play();
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
