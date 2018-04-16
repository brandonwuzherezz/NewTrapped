using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MasterBedroomToVault : MonoBehaviour
{

    public static bool vaultKey;

    void OnTriggerEnter(Collider col)
    {
        if (vaultKey)
        {
            if (col.gameObject.tag == "Player")
            {
                SceneManager.LoadScene("Vault");
                LoadLevel.MasterBedroomE = true;
            }
        }
    }
}