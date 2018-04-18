using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MasterBedroomToVault : MonoBehaviour
{

    public static bool vaultKey;
    public bool inTrigger;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = true;
            if (vaultKey)
            {
                SceneManager.LoadScene("Vault");
                LoadLevel.MasterBedroomE = true;
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
            if (!vaultKey)
            {
                GUI.Box(new Rect(200, 360, 200, 200), "You need a key to open door");
            }
        }
    }
}