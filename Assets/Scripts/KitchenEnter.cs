using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KitchenEnter : MonoBehaviour
{
    public static bool KitchenKey;
    public bool inTrigger;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = true;
            if (KitchenKey)
            {
                SceneManager.LoadScene("Kitchen");
                LoadLevel.Kitchen = true;
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
            if (!KitchenKey)
            {
                GUI.Box(new Rect(200, 360, 200, 200), "You need a key to open door");
            }
        }
    }
}