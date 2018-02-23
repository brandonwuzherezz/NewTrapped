using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBatteries : MonoBehaviour {

    void Update()
    {
        foreach (Transform child in this.transform)
        {
            if (Battery.DeletedBatteries.Contains("battery1") == false)
            {
                child.gameObject.SetActive(false);
            }
            else
            {
                child.gameObject.SetActive(true);
            }
        }

    }
}
