using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BathroomToBedroom1 : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Bedroom1");
            LoadLevel.BathroomA = true;
        }
    }
}
