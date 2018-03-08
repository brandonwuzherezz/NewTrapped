using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bedroom1ToBathroom : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Bathroom");
            LoadLevel.Bedroom1A = true;
        }
    }
}
