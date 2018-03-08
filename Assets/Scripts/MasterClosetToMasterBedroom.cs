using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MasterClosetToMasterBedroom : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag== "Player")
        {
            SceneManager.LoadScene("MasterBedroom");
            LoadLevel.MasterCloset = true;
        }
    }
}
