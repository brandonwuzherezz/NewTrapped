using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterTheDH : MonoBehaviour {

    public static bool dhKey;
    public bool inTrigger;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = true;
            if (dhKey)
            {
                SceneManager.LoadScene("5Dining Room");
                LoadLevel.DiningRoom = true;
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
            if (!dhKey)
            {
                GUI.Box(new Rect(200, 360, 200, 200), "You need a key to open door");
            }
        }
    }
}
