using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bedroom1ToHallway : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //SceneManager.LoadScene("Hallway");  Don't know Jay's Hallway name
            LoadLevel.Bedroom1B = true;
        }
    }
}

