using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    void Update()
    {
        foreach (Transform child in this.transform)
        {
            if (GameObject.Find("Girl").GetComponent<Player_Movement>().enabled == true)
            {
                child.gameObject.SetActive(true);
            }
            else
            {
                child.gameObject.SetActive(false);
            }
        }

    }
}
