using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BSHtoMasterBed : MonoBehaviour {

    public static bool MBKey;

    void OnTriggerEnter(Collider col)
    {
        if (MBKey)
        {

            if (col.gameObject.tag == "Player")
            {
                SceneManager.LoadScene("MasterBedroom");
                LoadLevel.BSHC = true;
            }
        }
    }
}
