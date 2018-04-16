using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterTheDH : MonoBehaviour {

    public static bool dhKey;


    void OnTriggerEnter(Collider col)
    {
        if (dhKey)
        {
            if (col.gameObject.tag == "Player")
            {
                SceneManager.LoadScene("5Dining Room");
                LoadLevel.DiningRoom = true;
            }
        }
    }
}
