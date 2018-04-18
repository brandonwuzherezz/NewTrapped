using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BSHtoMasterBed : MonoBehaviour {

    public static bool MBKey;
    public bool inTrigger;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = true;
            if (MBKey)
            {
                SceneManager.LoadScene("MasterBedroom");
                LoadLevel.BSHC = true;
                KeyManager.isImgOn = false;
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


    void OnGUI()
    {
        if (inTrigger)
        {
            if (!MBKey)
            {
                GUI.Box(new Rect(200, 360, 200, 200), "You need a key to open door");
            }
        }
    }
}
