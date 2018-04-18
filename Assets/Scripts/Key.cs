using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    public bool inTrigger;
    public static List<string> DeleteKeys = new List<string>();
    //public static int keys = 0;

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
        if (DeleteKeys.Contains(gameObject.name))
        {
            Destroy(gameObject);
        }

    }


    void Update()
    {
        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                EnterTheDH.dhKey = true;
                DeleteKeys.Add(gameObject.name);
                Destroy(gameObject);
                KeyManager.isImgOn = true;
            }
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
